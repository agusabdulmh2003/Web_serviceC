using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WebService
{
    /// <summary>
    /// Summary description for scholl
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class scholl : System.Web.Services.WebService
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

        [WebMethod]
        public string attentab_insert(int id, string namaSiswa, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO attentab (Id, NamaSiswa, Status) VALUES (@Id, @NamaSiswa, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@Status", status);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record inserted successfully.";
                        }
                        else
                        {
                            return "Error inserting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string attentab_update(int id, string namaSiswa, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE attentab SET NamaSiswa = @NamaSiswa, Status = @Status WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@Status", status);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string attentab_delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM attentab WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }
        [WebMethod]
        public string entab_insert(int id, string studentName, string section, DateTime enrollDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO entab (Id, StudentName, Section, EnrollDate) VALUES (@Id, @StudentName, @Section, @EnrollDate)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@EnrollDate", enrollDate);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record inserted successfully.";
                        }
                        else
                        {
                            return "Error inserting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string entab_update(int id, string studentName, string section, DateTime enrollDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE entab SET StudentName = @StudentName, Section = @Section, EnrollDate = @EnrollDate WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@EnrollDate", enrollDate);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string entab_delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM entab WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }
        [WebMethod]
        public string Sectiontab_insert(int sectionId, string studentName, string section)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Sectiontab (SectionId, StudentName, Section) VALUES (@SectionId, @StudentName, @Section)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectionId", sectionId);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@Section", section);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record inserted successfully.";
                        }
                        else
                        {
                            return "Error inserting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string Sectiontab_update(int sectionId, string studentName, string section)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Sectiontab SET StudentName = @StudentName, Section = @Section WHERE SectionId = @SectionId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectionId", sectionId);
                    cmd.Parameters.AddWithValue("@StudentName", studentName);
                    cmd.Parameters.AddWithValue("@Section", section);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string Sectiontab_delete(int sectionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Sectiontab WHERE SectionId = @SectionId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SectionId", sectionId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }
        [WebMethod]
        public string tabdaftar_insert(int nis, string namaSiswa, double rataRataNilai, DateTime tanggalPendaftaran)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tabdaftar (NIS, NamaSiswa, RataRataNilai, TanggalPendaftaran) VALUES (@NIS, @NamaSiswa, @RataRataNilai, @TanggalPendaftaran)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIS", nis);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@RataRataNilai", rataRataNilai);
                    cmd.Parameters.AddWithValue("@TanggalPendaftaran", tanggalPendaftaran);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record inserted successfully.";
                        }
                        else
                        {
                            return "Error inserting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabdaftar_update(int nis, string namaSiswa, double rataRataNilai, DateTime tanggalPendaftaran)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tabdaftar SET NamaSiswa = @NamaSiswa, RataRataNilai = @RataRataNilai, TanggalPendaftaran = @TanggalPendaftaran WHERE NIS = @NIS";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIS", nis);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@RataRataNilai", rataRataNilai);
                    cmd.Parameters.AddWithValue("@TanggalPendaftaran", tanggalPendaftaran);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabdaftar_delete(int nis)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tabdaftar WHERE NIS = @NIS";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIS", nis);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }
        [WebMethod]
        public string tabguru_insert(int idGuru, string namaGuru, string jenisKelamin, string nomorHp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tabguru (IDGuru, NamaGuru, JenisKelamin, NomorHp) VALUES (@IDGuru, @NamaGuru, @JenisKelamin, @NomorHp)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGuru", idGuru);
                    cmd.Parameters.AddWithValue("@NamaGuru", namaGuru);
                    cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                    cmd.Parameters.AddWithValue("@NomorHp", nomorHp);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record inserted successfully.";
                        }
                        else
                        {
                            return "Error inserting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabguru_update(int idGuru, string namaGuru, string jenisKelamin, string nomorHp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tabguru SET NamaGuru = @NamaGuru, JenisKelamin = @JenisKelamin, NomorHp = @NomorHp WHERE IDGuru = @IDGuru";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGuru", idGuru);
                    cmd.Parameters.AddWithValue("@NamaGuru", namaGuru);
                    cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                    cmd.Parameters.AddWithValue("@NomorHp", nomorHp);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabguru_delete(int idGuru)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tabguru WHERE IDGuru = @IDGuru";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IDGuru", idGuru);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }
        [WebMethod]
        public string tabkehadiran_insert(int nis, string namaSiswa, string presensi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tabkehadiran (NIS, NamaSiswa, Presensi) VALUES (@NIS, @NamaSiswa, @Presensi)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIS", nis);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@Presensi", presensi);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record inserted successfully.";
                        }
                        else
                        {
                            return "Error inserting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabkehadiran_update(int nis, string namaSiswa, string presensi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tabkehadiran SET NamaSiswa = @NamaSiswa, Presensi = @Presensi WHERE NIS = @NIS";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIS", nis);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@Presensi", presensi);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabkehadiran_delete(int nis)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tabkehadiran WHERE NIS = @NIS";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NIS", nis);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }
       
     
        [WebMethod]
        public string tabsiswa_update(int id, string namaSiswa, DateTime tanggal, string jenisKelamin, string nomorHp, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tabsiswa SET NamaSiswa = @NamaSiswa, Tanggal = @Tanggal, JenisKelamin = @JenisKelamin, NomorHp = @NomorHp, Email = @Email WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@NamaSiswa", namaSiswa);
                    cmd.Parameters.AddWithValue("@Tanggal", tanggal);
                    cmd.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                    cmd.Parameters.AddWithValue("@NomorHp", nomorHp);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record updated successfully.";
                        }
                        else
                        {
                            return "Error updating record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }

        [WebMethod]
        public string tabsiswa_delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tabsiswa WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Record deleted successfully.";
                        }
                        else
                        {
                            return "Error deleting record.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return "Error: " + ex.Message;
                    }
                }
            }
        }






    }
}
