using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace PMQLSVDH
{
    internal class DatabaseHelper
    {
        private static readonly string dbPath = "PMQLSVDH_v2.db";
        private static readonly string connectionString = $"Data Source={dbPath};";

        /// <summary>
        /// Tải dữ liệu giảng dạy kèm theo điểm của sinh viên
        /// </summary>
        /// <param name="MaGV">Mã giảng viên</param>
        /// <param name="dataGridView">DataGridView đích</param>
        public static void LoadDataGV(string MaGV, DataGridView dataGridView)
        {
            try
            {
                using var conn = new SqliteConnection(connectionString);
                conn.Open();

                // Sử dụng LEFT JOIN để hiển thị cả sinh viên chưa có điểm
                string query = @"
                    SELECT 
                        gv.TenGV AS [Giảng viên],
                        mh.MaMH AS [Mã môn],
                        mh.TenMH AS [Tên môn],
                        lh.MaLop AS [Mã lớp],
                        lh.TenLop AS [Tên lớp],
                        sv.MaSV AS [Mã SV],
                        sv.TenSV AS [Tên SV],
                        sv.NgaySinh AS [Ngày sinh],
                        sv.GioiTinh AS [Giới tính],
                        sv.DiaChi AS [Địa chỉ],
                        sv.Email AS [Email],
                        sv.SDT AS [SĐT],
                        d.Diem_CC AS [Điểm CC],
                        d.Diem_TX AS [Điểm TX],
                        d.Diem_THI AS [Điểm Thi],
                        d.Diem_HP AS [Điểm HP],
                        ROUND(
                            (COALESCE(d.Diem_CC, 0) + COALESCE(d.Diem_TX, 0) + COALESCE(d.Diem_THI, 0))
                            / CASE WHEN d.Diem_CC IS NULL OR d.Diem_TX IS NULL OR d.Diem_THI IS NULL THEN NULL ELSE 3 END
                        , 2) AS [Điểm TB]
                    FROM GiangVien gv
                    INNER JOIN GiangDay gd ON gv.MaGV = gd.MaGV
                    INNER JOIN MonHoc mh ON gd.MaMH = mh.MaMH
                    INNER JOIN LopHoc lh ON gd.MaLop = lh.MaLop
                    INNER JOIN SinhVien sv ON sv.MaLop = lh.MaLop
                    LEFT JOIN Diem d ON d.MaSV = sv.MaSV AND d.MaMH = mh.MaMH
                    WHERE gv.MaGV = @MaGV
                    ORDER BY lh.MaLop, sv.MaSV, mh.MaMH";

                using var cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGV", MaGV);

                using var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);

                dataGridView.AutoGenerateColumns = true;
                dataGridView.DataSource = dt;

                // Định dạng cột số
                dataGridView.Columns["Điểm CC"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Điểm TX"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Điểm Thi"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Điểm HP"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Điểm TB"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
