using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Clipboard.SetText("**** Descrição do Defeito ****" + "\n" + textBox1.Text + "\n" + "\n" + "**** Ambiente de Teste ****" + "\n" + "Sistema: " + comboBox3.Text + "\n" + "Versão: " + textBox3.Text + "\n" + "Base: " + textBox11.Text + "\n" + "Lotação: " + textBox5.Text + "\n" + "Usuário: " + textBox9.Text + "\n" + "Senha: " + textBox10.Text + "\n" + "Observações: " + textBox6.Text + "\n" + "\n" + "**** Procedimento do Teste ****" + "\n" + textBox7.Text + "\n" + "\n" + "**** Evidências ****" + "\n" + textBox8.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            textBox1.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
            textBox11.Text = String.Empty;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
                       }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Clipboard.SetText("**** Situação ****" + Environment.NewLine+ "APROVADO" + Environment.NewLine+ Environment.NewLine+ "**** Ambiente de Teste ****" + Environment.NewLine + "Sistema: " + comboBox2.Text + Environment.NewLine+ "Versão: " + textBox17.Text+ Environment.NewLine+"Base: " + textBox12.Text+ Environment.NewLine+"Lotação: "+ textBox16.Text+ Environment.NewLine+"Usuário: " + textBox14.Text+ Environment.NewLine+"Senha: "+ textBox13.Text+ Environment.NewLine+"Observações: "+ textBox15.Text+ Environment.NewLine+ Environment.NewLine+"**** Casos de Teste ****" + Environment.NewLine+ textBox21.Text + Environment.NewLine+ Environment.NewLine+"**** Resultado Esperado ****" + Environment.NewLine+ textBox19.Text + Environment.NewLine+ Environment.NewLine+"**** Evidências ****" + Environment.NewLine + textBox20.Text);
            }
            if (radioButton2.Checked)

            {
                Clipboard.SetText("**** Situação ****" + Environment.NewLine + "APROVADO COM MELHORIA" + Environment.NewLine + Environment.NewLine + "**** Ambiente de Teste ****" + Environment.NewLine + "Sistema: " + comboBox2.Text + Environment.NewLine + "Versão: " + textBox17.Text + Environment.NewLine + "Base: " + textBox12.Text + Environment.NewLine + "Lotação: " + textBox16.Text + Environment.NewLine + "Usuário: " + textBox14.Text + Environment.NewLine + "Senha: " + textBox13.Text + Environment.NewLine + "Observações: " + textBox15.Text + Environment.NewLine + Environment.NewLine + "**** Casos de Teste ****" + Environment.NewLine + textBox21.Text + Environment.NewLine + Environment.NewLine + "**** Resultado Esperado ****" + Environment.NewLine + textBox19.Text + Environment.NewLine + Environment.NewLine + "**** Evidências ****" + Environment.NewLine + textBox20.Text);
            }
            if (radioButton3.Checked)
            {
                Clipboard.SetText("**** Situação ****" + Environment.NewLine + "REPROVADO" + Environment.NewLine + Environment.NewLine + "**** Ambiente de Teste ****" + Environment.NewLine + "Sistema: " + comboBox2.Text + Environment.NewLine + "Versão: " + textBox17.Text + Environment.NewLine + "Base: " + textBox12.Text + Environment.NewLine + "Lotação: " + textBox16.Text + Environment.NewLine + "Usuário: " + textBox14.Text + Environment.NewLine + "Senha: " + textBox13.Text + Environment.NewLine + "Observações: " + textBox15.Text + Environment.NewLine + Environment.NewLine + "**** Casos de Teste ****" + Environment.NewLine + textBox21.Text + Environment.NewLine + Environment.NewLine + "**** Resultado Esperado ****" + Environment.NewLine + textBox19.Text + Environment.NewLine + Environment.NewLine + "**** Evidências ****" + Environment.NewLine + textBox20.Text);
            }
            if (radioButton4.Checked)
            {
                Clipboard.SetText("**** Situação ****" + Environment.NewLine + "BLOQUEADO" + Environment.NewLine + Environment.NewLine + "**** Ambiente de Teste ****" + Environment.NewLine + "Sistema: " + comboBox2.Text + Environment.NewLine + "Versão: " + textBox17.Text + Environment.NewLine + "Base: " + textBox12.Text + Environment.NewLine + "Lotação: " + textBox16.Text + Environment.NewLine + "Usuário: " + textBox14.Text + Environment.NewLine + "Senha: " + textBox13.Text + Environment.NewLine + "Observações: " + textBox15.Text + Environment.NewLine + Environment.NewLine + "**** Casos de  Teste ****" + Environment.NewLine + textBox21.Text + Environment.NewLine + Environment.NewLine + "**** Resultado Esperado ****" + Environment.NewLine + textBox19.Text + Environment.NewLine + Environment.NewLine + "**** Evidências ****" + Environment.NewLine + textBox20.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
                    {
            Clipboard.Clear();
            textBox17.Text = String.Empty;
            textBox12.Text = String.Empty;
            textBox16.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox14.Text = String.Empty;
            textBox13.Text = String.Empty;
            textBox15.Text = String.Empty;
            textBox21.Text = String.Empty;
            textBox19.Text = String.Empty;
            textBox20.Text = String.Empty;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Prezados," + Environment.NewLine+"O setor de Qualidade está disponibilizando para liberação a nova versão release do sistema SAJSG5." + Environment.NewLine+ Environment.NewLine+"**** Dados da Versão ****" + Environment.NewLine + "Versão: "+ textBox4.Text+ Environment.NewLine+"Cliente: " + comboBox1.Text + Environment.NewLine+"Data: "+ dateTimePicker1.Text+ Environment.NewLine + "**** Salts Vinculadas ****"+ Environment.NewLine+ textBox22.Text+ Environment.NewLine + Environment.NewLine+"Qualquer dúvida ou problema, estamos à disposição.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            textBox4.Text = String.Empty;
            comboBox1.Text = String.Empty;
            textBox22.Text = String.Empty;
                  }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }

    }



