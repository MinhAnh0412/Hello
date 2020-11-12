using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAROGAME
{
    public partial class Form1 : Form
    {
        #region Properties
        Chessmanager Chessboard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Chessboard = new Chessmanager(panelchessboard, playername, picturematch);

            Chessboard.Drawchessboard();
        }
        
    }
}
