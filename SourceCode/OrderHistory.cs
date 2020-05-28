using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class OrderHistory : UserControl
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            actualizar();
        }
        private void actualizar()
        {
            //Actualizar DataGrid1
            var datagridusuarios = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                             "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                             "WHERE ao.idProduct = pr.idProduct "+
                                                             "AND ao.idAddress = ad.idAddress " +
                                                             "AND ad.idUser = au.idUser");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datagridusuarios;
        }
    }
}