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
                        lh.TenLop AS [Lớp],
                        sv.MaSV AS [Mã SV],
                        sv.TenSV AS [Họ và tên],
                        sv.NgaySinh AS [Ngày sinh],
                        sv.GioiTinh AS [Giới tính],
                        d.Diem_CC AS [Điểm CC],
                        d.Diem_TX AS [Điểm TX],
                        d.Diem_THI AS [Điểm THI],
                        d.Diem_HP AS [Điểm HP]
                    FROM GiangVien gv
                    INNER JOIN GiangDay gd ON gv.MaGV = gd.MaGV
                    INNER JOIN MonHoc mh ON gd.MaMH = mh.MaMH
                    INNER JOIN LopHoc lh ON gd.MaLop = lh.MaLop
                    INNER JOIN SinhVien sv ON sv.MaLop = lh.MaLop
                    LEFT JOIN Diem d ON d.MaSV = sv.MaSV AND d.MaMH = mh.MaMH
                    WHERE gv.MaGV = @MaGV
                    ORDER BY lh.MaLop, sv.MaSV";

                using var cmd = new SqliteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGV", MaGV);

                using var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);

                // Tắt tự động tạo cột và ánh xạ dữ liệu vào các cột đã định nghĩa
                dataGridView.AutoGenerateColumns = false;

                dataGridView.Columns["LopHoc"].DataPropertyName = "Lớp";
                dataGridView.Columns["MaSV"].DataPropertyName = "Mã SV";
                dataGridView.Columns["TenSV"].DataPropertyName = "Họ và tên";
                dataGridView.Columns["NgaySinh"].DataPropertyName = "Ngày sinh";
                dataGridView.Columns["GioiTinh"].DataPropertyName = "Giới tính";
                dataGridView.Columns["Diem_CC"].DataPropertyName = "Điểm CC";
                dataGridView.Columns["Diem_TX"].DataPropertyName = "Điểm TX";
                dataGridView.Columns["Diem_THI"].DataPropertyName = "Điểm THI";
                dataGridView.Columns["Diem_HP"].DataPropertyName = "Điểm HP";

                dataGridView.DataSource = dt;

                // Định dạng cột số
                dataGridView.Columns["Diem_CC"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Diem_TX"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Diem_THI"].DefaultCellStyle.Format = "N1";
                dataGridView.Columns["Diem_HP"].DefaultCellStyle.Format = "N1";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
