using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class d : Form
    {
        public int count = -1;
        public char x = 'X';
        public char o = 'O';
        public bool yesVis = false;
        public d()
        {
            InitializeComponent();
            /*            button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button8.Visible = false;
                        button9.Visible = false;*/
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox5.Visible = true;
            else
                pictureBox14.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox6.Visible = true;
            else
                pictureBox15.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox7.Visible = true;
            else
                pictureBox16.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox8.Visible = true;
            else
                pictureBox17.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox9.Visible = true;
            else
                pictureBox18.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox10.Visible = true;
            else
                pictureBox19.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox11.Visible = true;
            else
                pictureBox20.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox12.Visible = true;
            else
                pictureBox21.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
                pictureBox13.Visible = true;
            else
                pictureBox22.Visible = true;
            count++;

            label1.Text = $"GameMoves: {count + 1}";
            if (count % 2 == 0)
                label2.Text = $"Turn: {o}";
            else
                label2.Text = $"Turn: {x}";
            IsWon();
            Reset();

        }
        private void Reset()
        {
            if (yesVis)
            {
                if (label2.Text.Equals($"Turn: {o}"))
                {
                    if (Xwon.Visible)
                    {
                        //X
                        pictureBox14.Visible = true;
                        pictureBox15.Visible = true;
                        pictureBox16.Visible = true;
                        pictureBox17.Visible = true;
                        pictureBox18.Visible = true;
                        pictureBox19.Visible = true;
                        pictureBox20.Visible = true;
                        pictureBox21.Visible = true;
                        pictureBox22.Visible = true;

                        //O
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = false;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                        pictureBox13.Visible = false;
                    }
                    else if (Twon.Visible)
                    {//x
                        pictureBox14.Visible = true;
                        pictureBox18.Visible = true;
                        pictureBox22.Visible = true;
                        pictureBox16.Visible = true;
                        pictureBox20.Visible = true;
                        //o
                        pictureBox12.Visible = true;
                        pictureBox8.Visible = true;
                        pictureBox6.Visible = true;
                        pictureBox10.Visible = true;
                        //turndown
                        pictureBox21.Visible = false;
                        pictureBox17.Visible = false;
                        pictureBox15.Visible = false;
                        pictureBox19.Visible = false;


                    }

                }
                else
                {
                    //X
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox22.Visible = false;

                    //O
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                }



            }
        }
        private void IsWon()
        {//lines
            if (pictureBox14.Visible && pictureBox15.Visible && pictureBox16.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                ltx.Visible = true;
            }
            if (pictureBox17.Visible && pictureBox18.Visible && pictureBox19.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                lmx.Visible = true;
            }
            if (pictureBox20.Visible && pictureBox21.Visible && pictureBox22.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                lbx.Visible = true;
            }//cols
            if (pictureBox14.Visible && pictureBox19.Visible && pictureBox20.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                cl.Visible = true;
            }
            if (pictureBox15.Visible && pictureBox18.Visible && pictureBox21.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                cm.Visible = true;
            }
            if (pictureBox16.Visible && pictureBox17.Visible && pictureBox22.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                cr.Visible = true;
            }//diagonal      
            if (pictureBox14.Visible && pictureBox18.Visible && pictureBox22.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                dr1.Visible = true;
                dr2.Visible = true;
                dr3.Visible = true;
            }
            if (pictureBox16.Visible && pictureBox18.Visible && pictureBox20.Visible)
            {
                Xwon.Visible = true;
                count = -1;
                yesVis = true;
                dl1.Visible = true;
                dl2.Visible = true;
                dl3.Visible = true;
            }

            //__________________________________________
            // O - lines
            if (pictureBox5.Visible && pictureBox6.Visible && pictureBox7.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                ltx.Visible = true;
            }
            if (pictureBox8.Visible && pictureBox9.Visible && pictureBox10.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                lmx.Visible = true;
            }
            if (pictureBox11.Visible && pictureBox12.Visible && pictureBox13.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                lbx.Visible = true;
            }//cols
            if (pictureBox5.Visible && pictureBox10.Visible && pictureBox11.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                cl.Visible = true;
            }
            if (pictureBox6.Visible && pictureBox9.Visible && pictureBox12.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                cm.Visible = true;
            }
            if (pictureBox7.Visible && pictureBox8.Visible && pictureBox13.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                cr.Visible = true;
            }//diagonal      
            if (pictureBox5.Visible && pictureBox9.Visible && pictureBox13.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                dr1.Visible = true;
                dr2.Visible = true;
                dr3.Visible = true;
            }
            if (pictureBox7.Visible && pictureBox9.Visible && pictureBox11.Visible)
            {
                Owon.Visible = true;
                count = -1;
                yesVis = true;
                dl1.Visible = true;
                dl2.Visible = true;
                dl3.Visible = true;
            }
            if (label1.Text.Equals("GameMoves: 9") && !Owon.Visible  && !Xwon.Visible)
            {
                Twon.Visible = true;
                yesVis = true; 
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            count = -1;
            yesVis = false;
            label2.Text = "Turn: X";
            label1.Text = "GameMove: 0";
            trullyReset.Checked = false;
            ltx.Visible = false;
            lmx.Visible = false;
            lbx.Visible = false;
            cl.Visible = false;
            cm.Visible = false;
            cr.Visible = false;
            dr1.Visible = false;
            dr2.Visible = false;
            dr3.Visible = false;
            dl1.Visible = false;
            dl2.Visible = false;
            dl3.Visible = false;
            Xwon.Visible = false;
            Owon.Visible = false;
            Twon.Visible = false;
        }
    }
}
