using System.Windows.Forms;

namespace QuanLyThuVien_WF
{
    class AddTab
    {
        #region AddTab
        public class TabAdd
        {
            public void AddTab(DevExpress.XtraTab.XtraTabControl xtraTabCha, string icon, string TabNameAdd, System.Windows.Forms.UserControl UserControl)
            {
                DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
                TAbAdd.Name = "TestTab";
                TAbAdd.Text = TabNameAdd;
                TAbAdd.Controls.Add(UserControl);
                UserControl.Dock = DockStyle.Fill;
                try
                {
                    TAbAdd.Image = System.Drawing.Bitmap.FromFile(System.Windows.Forms.Application.StartupPath.ToString() + @"\Icons\" + icon);
                }
                catch
                {

                }
                xtraTabCha.TabPages.Add(TAbAdd);
            }
        }
        #endregion
        #region RemoveTab
        public void RemoveTab(DevExpress.XtraTab.XtraTabControl XtraTabCha, System.Windows.Forms.UserControl UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage) 
            DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab 
            tab.Name = "TestTab";
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            tab.Controls.Remove(UserControl);
            XtraTabCha.TabPages.Remove(tab);
        }
        #endregion
    }
}
