using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class AddToCart : Form
    {
        public Tools.ProductHelper productData = new Tools.ProductHelper();
        public EventHandler<Tools.ProductHelper> ProductAdded;
        public frmSell parentForm;
        public AddToCart(Tools.ProductHelper pData)
        {
            this.productData = pData;
            InitializeComponent();
            if (productData.Id != 0)
            {
                //TODO -------------->
                txtID.Text = productData.Id.ToString();
                txtName.Text = productData.Name;
                txtPrice.Text = productData.Price.ToString();
                txtStock.Text = productData.Stock.ToString();
                txtUniTypeName.Text = productData.UnitTypeName;
                nudAmount.Maximum = productData.Stock;
                nudAmount.Focus();
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            productData.BuyAmount = Tools.TryParseInt(nudAmount.Value.ToString());
            productData.Subtotal = productData.Price * productData.BuyAmount;
            ProductAdded?.Invoke(this, productData);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
