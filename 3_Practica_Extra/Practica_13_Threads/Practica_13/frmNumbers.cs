using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_13 {
    public partial class frmNumbers : Form {

        List<MyRectangle> rectanglesList;
        Thread babyThread;
        bool activated;

        public frmNumbers() {
            InitializeComponent();
            rectanglesList = new List<MyRectangle>();
            rectanglesList.Add(new MyRectangle(20, 0, 20, 20, Color.Black));
            activated = false;
            babyThread = new Thread(new ThreadStart(MoverOuch));
        }

        private void frmNumbers_Paint(object sender, PaintEventArgs e) {
            Pen color = new Pen(Color.Aquamarine);
            foreach (MyRectangle item in rectanglesList) {
                for (int i = 0; i < 20; i++) {
                    e.Graphics.DrawRectangle(color, item.X, item.Y, item.Width, item.Height);
                }
            }
        }

        private void DrawRectangle(MyRectangle rec) {
            for (int i = 0; i < this.Height - rec.Height - 39; i++) {
                rec.Y = (this.rectanglesList[0].Y + 5);
                this.Refresh();
                //this.Invoke(Refresh());
                Thread.Sleep(100);
            }
        }

        private void btn1_Click(object sender, EventArgs e) {
            if (!activated) {
                MoverOuch();
                activated = !activated;
            }
        }

        private void MoverOuch() {
            foreach (MyRectangle item in rectanglesList) {
                DrawRectangle(item);
            }
        }

        private void frmNumbers_FormClosing(object sender, FormClosingEventArgs e) {
            if (babyThread.IsAlive) {
                babyThread.Abort();
            }
        }
    }
}
