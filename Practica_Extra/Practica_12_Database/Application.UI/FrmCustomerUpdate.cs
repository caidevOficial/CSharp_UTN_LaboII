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
using Application.DAO;

namespace WindowsFormsApp1 {
    public partial class FrmCustomerUpdate : FrmCustomer {
        
        #region Attribute

        Customer auxCustomer;

        #endregion

        #region Builders

        public FrmCustomerUpdate(CustomerRepository customerRepository, Customer customer) : base(customerRepository) {
            this.auxCustomer = customer;

            this.txtAge.Text = customer.Age.ToString();
            this.txtLastName.Text = customer.LastName;
            this.txtName.Text = customer.Name;
            this.btnAdd.Enabled = false;
            InitializeComponent();

        }

        #endregion

        #region ButtonsEventHasndlers

        /// <summary>
        /// EventHandler of the button Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e) {
            Customer newCustomer = new Customer() {
                Name = this.txtName.Text,
                LastName = this.txtLastName.Text,
                ID = auxCustomer.ID,
                Age = Convert.ToInt32(this.txtAge.Text)
            };
            DataAccess.UpdateCustomer(newCustomer);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

    }
}
