using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Data.SqlClient;
using System.Data;

namespace TEST
{
    public partial class frm_Main : Form
    {
        SqlConnection conn = Bus_Layer.ConnectData();
        GV gv = new GV();
        public frm_Main()
        {
            InitializeComponent();
            load_cbo_CoSo();
            load_cbo_DonVi();
        }

        private void load_cbo_CoSo()
        {
            cbo_CoSo.Items.Add("CS1");
            cbo_CoSo.Items.Add("CS2");
        }
        private void load_cbo_DonVi()
        {
            cbo_DonVi.Items.Add("DV1");
            cbo_DonVi.Items.Add("DV2");
        }
        private void cbo_CoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cbo_CoSo.SelectedItem.ToString();
            dtgv_GV.DataSource = Bus_Layer.GetDonVi(option);
        }

        private void cbo_DonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cbo_DonVi.SelectedItem.ToString();            
            dtgv_GV.DataSource = Bus_Layer.GetGV(option);
            dtgv_GV.Columns[1].Visible = false;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //dtgv_GV.DataSource = Bus_Layer.GetGV();
        }

        private void dtgv_GV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {                
                dtgv_GV.ClearSelection();
                dtgv_GV.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;

                if (dtgv_GV.Rows[e.RowIndex].Cells[e.ColumnIndex].ContextMenuStrip == null)
                {
                    dtgv_GV.Rows[e.RowIndex].Cells[e.ColumnIndex].ContextMenuStrip = cellContextMenu;
                }
                menuOption1.Click += menuOption1_Click;
                //menuOption2.Click += menuOption2_Click;
                dtgv_GV.Rows[e.RowIndex].Cells[e.ColumnIndex].ContextMenuStrip.Show(Cursor.Position);
            }            
        }

        private void dtgv_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_GV.Rows[e.RowIndex];                
                gv.MAGV = row.Cells[1].Value.ToString();
            }
            catch
            {
                
            }
        }

        private void menuOption1_Click(object sender, EventArgs e)
        {
            dtgv_GV.DataSource = Bus_Layer.GetInfoGV(gv.MAGV);
        }
    }
}
