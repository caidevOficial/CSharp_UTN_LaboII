/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Application.Models;
using Application.Repositories;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class FrmCustomerVisualizer : Form {

        #region Attributes

        private CustomerRepository customerRepository;

        #endregion

        #region Builder

        public FrmCustomerVisualizer(CustomerRepository customerRepository) {
            InitializeComponent();
            this.customerRepository = customerRepository;
        }

        #endregion

        #region ButtonsEventHandlers

        /// <summary>
        /// Load Event of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCostumerVisualizer_Load(object sender, EventArgs e) {
            this.RefreshDataGrid();
        }

        /// <summary>
        /// EventHandler of the button Add.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) {
            FrmCustomer frm = new FrmCustomer(this.customerRepository);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK) {
                this.RefreshDataGrid();
            }
        }

        /// <summary>
        /// EventHandler of the button Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e) {
            FrmCustomerUpdate frm = new FrmCustomerUpdate(this.customerRepository, (Customer)dtgCustomer.CurrentRow.DataBoundItem);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK) {
                this.RefreshDataGrid();
            }
        }

        /// <summary>
        /// EventHandler of the button Delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e) {

            if (DialogResult.Yes == MessageBox.Show("Seguro que desea Eliminar el cliente?", "Atencion", MessageBoxButtons.YesNo)) {
                this.customerRepository.Remove((Customer)dtgCustomer.CurrentRow.DataBoundItem);
                this.RefreshDataGrid();
            }

        }

        /// <summary>
        /// Refresh the visual of the data grid.
        /// </summary>
        private void RefreshDataGrid() {
            dtgCustomer.DataSource = null;
            dtgCustomer.DataSource = this.customerRepository.GetAll();
        }

        #endregion

    }
}
