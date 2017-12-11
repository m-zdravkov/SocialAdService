using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.SaServicePublic;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class CommentUserControl : UserControl
    {
        public CommentUserControl(Comment comment)
        {
            InitializeComponent();
            DisplayComment(comment);
        }

        private void DisplayComment(Comment comment)
        {
            LblAuthor.Text = comment.Author.Name;
            LblDatePosted.Text = comment.DatePosted.ToShortDateString();
            LblTimePosted.Text = comment.DatePosted.ToShortTimeString();
            RtbComment.Text = comment.Content;
        }
    }
}
