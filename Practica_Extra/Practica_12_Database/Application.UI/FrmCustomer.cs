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

using Application.Helpers;
using Application.Models;
using Application.Repositories;
using System;
using System.Windows.Forms;
using Application.DAO;

namespace WindowsFormsApp1 {
    public partial class FrmCustomer : Form {

        #region Attibutes

        protected CustomerRepository customerRepository;

        #endregion

        #region Builders       

        public FrmCustomer() {
            InitializeComponent();
        }

        public FrmCustomer(CustomerRepository customerRepository) : this() {
            this.customerRepository = customerRepository;
        }

        #endregion

        #region ButtonsEventHandlers

        /// <summary>
        /// EventHandler of the button Cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// EventHandler of the button Add.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e) {
            Customer customer = new Customer(txtName.Text, txtLastName.Text, Convert.ToInt32(txtAge.Text));
            try {
                DataAccess.InsertCustomer(customer);
                //this.customerRepository.Create(customer);
                MessageBox.Show("Cliente Crado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logger.LogException(exc.Message);
            }
        }

        #endregion
    }
}
