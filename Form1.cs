using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace GuiDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        disable_all();
        radioButton1_CheckedChanged(this, EventArgs.Empty);
        textBox1_TextChanged(this, EventArgs.Empty);
        textBox2_TextChanged(this, EventArgs.Empty);
        textBox13_TextChanged(this, EventArgs.Empty);
        textBox12_TextChanged(this, EventArgs.Empty);
        textBox44_TextChanged(this, EventArgs.Empty);

        textBox23_TextChanged(this, EventArgs.Empty);
        textBox24_TextChanged(this, EventArgs.Empty);
        textBox33_TextChanged(this, EventArgs.Empty);
        textBox34_TextChanged(this, EventArgs.Empty);

        textBox19_TextChanged(this, EventArgs.Empty);

        textBox1.SelectAll();
        textBox2.SelectAll();
        textBox13.SelectAll();
        textBox12.SelectAll();
        textBox23.SelectAll();
        textBox24.SelectAll();
        textBox33.SelectAll();
        textBox34.SelectAll();

        textBox5.Hide();
        textBox6.Hide();
        textBox7.Hide();
        textBox30.Hide();
        textBox31.Hide();
        textBox32.Hide();
        label13.Hide();
        label14.Hide();
        label15.Hide();
    }
    
    private void enable_all()
    {
        textBox7.Enabled = true;
        textBox6.Enabled = true;
        textBox5.Enabled = true;
        textBox14.Enabled = true;
        textBox15.Enabled = true;
        textBox4.Enabled = true;
        textBox3.Enabled = true;
        textBox16.Enabled = true;
        textBox17.Enabled = true;
        textBox18.Enabled = true;
        textBox20.Enabled = true;
        textBox21.Enabled = true;
        textBox22.Enabled = true;
        textBox25.Enabled = true;
        textBox30.Enabled = true;
        textBox31.Enabled = true;
        textBox32.Enabled = true;
        textBox35.Enabled = true;
        textBox36.Enabled = true;
        textBox37.Enabled = true;
        textBox38.Enabled = true;
        textBox39.Enabled = true;
        textBox40.Enabled = true;
        textBox41.Enabled = true;
        textBox42.Enabled = true;
        textBox43.Enabled = true;
    }

    private void disable_all()
    {
        textBox7.Enabled = false;
        textBox6.Enabled = false;
        textBox5.Enabled = false;
        textBox14.Enabled = false;
        textBox15.Enabled = false;
        textBox3.Enabled = false;
        textBox4.Enabled = false;
        textBox16.Enabled = false;
        textBox17.Enabled = false;
        textBox18.Enabled = false;
        textBox20.Enabled = false;
        textBox21.Enabled = false;
        textBox22.Enabled = false;
        textBox25.Enabled = false;
        textBox30.Enabled = false;
        textBox31.Enabled = false;
        textBox32.Enabled = false;
        textBox35.Enabled = false;
        textBox36.Enabled = false;
        textBox37.Enabled = false;
        textBox38.Enabled = false;
        textBox39.Enabled = false;
        textBox40.Enabled = false;
        textBox41.Enabled = false;
        textBox42.Enabled = false;
        textBox43.Enabled = false;
    }
    private void disable_parameters()
    {
        textBox8.Enabled = false;
        textBox9.Enabled = false;
        textBox10.Enabled = false;
        textBox11.Enabled = false;
    }

    private void enable_parameters()
    {
        textBox8.Enabled = true;
        textBox9.Enabled = true;
        textBox10.Enabled = true;
        textBox11.Enabled = true;
    }
    private void update_data(object sender, EventArgs e)
    {
        textBox11_TextChanged(sender, e);
        textBox10_TextChanged(sender, e);
        textBox9_TextChanged(sender, e);
        textBox8_TextChanged(sender, e);
        textBox7_TextChanged(sender, e);
        textBox6_TextChanged(sender, e);
        textBox5_TextChanged(sender, e);
        textBox12_TextChanged(sender, e);
        textBox13_TextChanged(sender, e);
        textBox14_TextChanged(sender, e);
        textBox15_TextChanged(sender, e);
        textBox4_TextChanged(sender, e);
        textBox16_TextChanged_1(sender, e);
        textBox17_TextChanged(sender, e);
        textBox18_TextChanged(sender, e);
        textBox19_TextChanged(sender, e);
        textBox20_TextChanged(sender, e);
        textBox21_TextChanged(sender, e);
        textBox22_TextChanged(sender, e);

        textBox26_TextChanged(sender, e);
        textBox30_TextChanged(sender, e);
        textBox31_TextChanged(sender, e);
        textBox32_TextChanged(sender, e);
        textBox35_TextChanged(sender, e);
        textBox36_TextChanged(sender, e);
        textBox37_TextChanged(sender, e);
        textBox38_TextChanged(sender, e);
        textBox39_TextChanged(sender, e);
        textBox40_TextChanged(sender, e);
        textBox41_TextChanged(sender, e);
        textBox42_TextChanged(sender, e);
        textBox43_TextChanged(sender, e);
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        update_data(sender, e);
        enable_all();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e) 
    {
        
    }

    // Trayectoria km carretera
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string trayecto = textBox1.Text;
        if (!double.TryParse(trayecto, out double d))
        {
            textBox1.Text = "0";
        }
        disable_all();
    }

    // Precio Diesel galon
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (double.TryParse(textBox2.Text, out double d) || int.TryParse(textBox2.Text, out int i))
        {
            textBox3_TextChanged(sender, e);   
        }
        else
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
        disable_all();
    }

    // Costo operario por dia
    private void textBox13_TextChanged(object sender, EventArgs e)
    {
        string costo_comida = textBox13.Text;
        if (!double.TryParse(costo_comida, out double d))
        {
            textBox13.Text = "0";
        }
        disable_all();
    }

    // Costo comida por dia
    private void textBox12_TextChanged(object sender, EventArgs e)
    {
        string costo_comida = textBox12.Text;
        if (!double.TryParse(costo_comida, out double d))
        {
            textBox12.Text = "0";
        }
        disable_all();
    }

    // Precio depreciacion
    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        textBox3.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox2.Text) * 0.25, 2));
    }

    // Rendimiento descargado
    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox11.Text, out double d))
        {
            textBox11.Text = "0";
        }
    }

    // Rendimiento 25%
    private void textBox8_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox8.Text, out double d))
        {
            textBox8.Text = "0";
        }
    }

    // Rendimiento 50%
    private void textBox9_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox9.Text, out double d))
        {
            textBox9.Text = "0";
        }
    }

    // Rendimiento 100%
    private void textBox10_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox10.Text, out double d))
        {
            textBox10.Text = "0";
        }
    }

    // Costo 25% Retorno 0
    private void textBox7_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox1.Text);
        double rend_descargado = Convert.ToDouble(textBox11.Text);
        double rend25 = Convert.ToDouble(textBox8.Text);
        double precio_diesel = Convert.ToDouble(textBox2.Text);
        double precio_dep = Convert.ToDouble(textBox3.Text);
        double cost25 = Math.Round(trayectoria / rend25 * (precio_diesel + precio_dep) + trayectoria / rend_descargado * (precio_diesel + precio_dep), 2);
        textBox7.Text = cost25.ToString();
    }

    // Costo 50% Retorno 0
    private void textBox6_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox1.Text);
        double rend_descargado = Convert.ToDouble(textBox11.Text);
        double rend50 = Convert.ToDouble(textBox9.Text);
        double precio_diesel = Convert.ToDouble(textBox2.Text);
        double precio_dep = Convert.ToDouble(textBox3.Text);
        double cost50 = Math.Round(trayectoria / rend50 * (precio_diesel + precio_dep) + trayectoria / rend_descargado * (precio_diesel + precio_dep), 2);
        textBox6.Text = cost50.ToString();

    }

    // Costo a mas de 50% retorno 0
    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox1.Text);
        double rend_descargado = Convert.ToDouble(textBox11.Text);
        double rend100 = Convert.ToDouble(textBox10.Text);
        double precio_diesel = Convert.ToDouble(textBox2.Text);
        double precio_dep = Convert.ToDouble(textBox3.Text);
        double cost100 = Math.Round(trayectoria / rend100 * (precio_diesel + precio_dep) + trayectoria / rend_descargado * (precio_diesel + precio_dep), 2);
        textBox5.Text = cost100.ToString();
    }

    // Costo total al 0 - 25%
    private void textBox14_TextChanged(object sender, EventArgs e)
    {
        double cost25 = Convert.ToDouble(textBox7.Text);
        double costo_operario = Convert.ToDouble(textBox12.Text);
        double costo_comida = Convert.ToDouble(textBox13.Text);
        double costo_total25 = Math.Round(cost25 + costo_operario + costo_comida, 2);
        textBox14.Text = costo_total25.ToString();
    }

    // Costo total al 25 - 50%
    private void textBox15_TextChanged(object sender, EventArgs e)
    {
        double cost50 = Convert.ToDouble(textBox6.Text);
        double costo_operario = Convert.ToDouble(textBox12.Text);
        double costo_comida = Convert.ToDouble(textBox13.Text);
        double costo_total25 = Math.Round(cost50 + costo_operario + costo_comida, 2);
        textBox15.Text = costo_total25.ToString();
    }

    // Costo a mas de 50%
    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        double cost100 = Convert.ToDouble(textBox5.Text);
        double costo_operario = Convert.ToDouble(textBox12.Text);
        double costo_comida = Convert.ToDouble(textBox13.Text);
        double costo_total25 = Math.Round(cost100 + costo_operario + costo_comida, 2);
        textBox4.Text = costo_total25.ToString();
    }

    // Cobrar 0 - 25
    private void textBox16_TextChanged_1(object sender, EventArgs e)
    {
        double ganancia = Convert.ToDouble(textBox44.Text) / 100;
        double cobro25 = Math.Round(Convert.ToDouble(textBox14.Text) / (1 - ganancia), 2);
        textBox16.Text = cobro25.ToString();
    }

    // Cobrar 25 - 50
    private void textBox17_TextChanged(object sender, EventArgs e)
    {
        double ganancia = Convert.ToDouble(textBox44.Text) / 100;
        double cobro50 = Math.Round(Convert.ToDouble(textBox15.Text) / (1 - ganancia), 2);
        textBox17.Text = cobro50.ToString();
        textBox18_TextChanged(sender, e);
    }

    // Cobrar 100
    private void textBox18_TextChanged(object sender, EventArgs e)
    {
        double ganancia = Convert.ToDouble(textBox44.Text) / 100;
        double cobro100 = Math.Round(Convert.ToDouble(textBox4.Text) / (1 - ganancia), 2);
        textBox18.Text = cobro100.ToString();
    }
    
    // Descuento
    private void textBox19_TextChanged(object sender, EventArgs e)
    {
        string dsc = textBox19.Text;
        if (!Double.TryParse(dsc, out double d))
        {
            textBox19.Text = "0";
        }
        disable_all();
    }

    // Precio25 con descuento
    private void textBox20_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double cobro25 = Convert.ToDouble(textBox16.Text);
        double precio_des25 = Math.Round(cobro25 * (1.0 - (dsc / 100)), 2);
        textBox20.Text = precio_des25.ToString();
    }

    // Precio50 con descuento 
    private void textBox21_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double cobro50 = Convert.ToDouble(textBox17.Text);
        double precio_des25 = Math.Round(cobro50 * (1.0 - (dsc / 100)), 2);
        textBox21.Text = precio_des25.ToString();
    }

    // Precio100 con descuento 
    private void textBox22_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double cobro100 = Convert.ToDouble(textBox18.Text);
        double precio_des25 = Math.Round(cobro100 * (1.0 - (dsc / 100)), 2);
        textBox22.Text = precio_des25.ToString();
    }

    //////////////////////////////////////////////////////////////////////////
    // Trayecto km CIUDAD
    private void textBox23_TextChanged(object sender, EventArgs e)
    {
        string trayecto = textBox23.Text;
        if (!double.TryParse(trayecto, out double d))
        {
            textBox23.Text = "0";
        }
        disable_all();
    }

    // Precio Diesel CIUDAD
    private void textBox24_TextChanged(object sender, EventArgs e)
    {
        string precio_diesel = textBox24.Text;
        if (!double.TryParse(precio_diesel, out double d))
        {
            textBox24.Text = "0";
        }
        else
        {
            textBox25_TextChanged(sender, e);
        }
        disable_all();
    }

    // Precio Depreciacion CIUDAD
    private void textBox25_TextChanged(object sender, EventArgs e)
    {
        textBox25.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox24.Text) * 0.25, 2));
    }
    
    // Rendimiento descargado CIUDAD
    private void textBox26_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox26.Text, out double d))
        {
            textBox26.Text = "0";
        }
    }

    // Rendimiento 25% CIUDAD
    private void textBox27_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox27.Text, out double d))
        {
            textBox27.Text = "0";
        }
    }

    // Rendimiento 50% CIUDAD
    private void textBox28_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox28.Text, out double d))
        {
            textBox28.Text = "0";
        }
    }

    // Rendimiento 100% CIUDAD
    private void textBox29_TextChanged(object sender, EventArgs e)
    {
        if (!double.TryParse(textBox29.Text, out double d))
        {
            textBox29.Text = "0";
        }
    }

    // Costo al 25% Retorno 0 CIUDAD
    private void textBox30_TextChanged(object sender, EventArgs e)
    {
        double rend_descargado = Convert.ToDouble(textBox26.Text);
        double rend25 = Convert.ToDouble(textBox27.Text);
        double precio_diesel = Convert.ToDouble(textBox24.Text);
        double precio_dep = Convert.ToDouble(textBox25.Text);
        double cost25 = Math.Round(25.0 / rend25 * (precio_diesel + precio_dep) + 25.0 / rend_descargado * (precio_diesel + precio_dep), 2);
        textBox30.Text = cost25.ToString();
    }

    // Costo al 50% Retorno 0 CIUDAD
    private void textBox31_TextChanged(object sender, EventArgs e)
    {
        double rend_descargado = Convert.ToDouble(textBox26.Text);
        double rend50 = Convert.ToDouble(textBox28.Text);
        double precio_diesel = Convert.ToDouble(textBox24.Text);
        double precio_dep = Convert.ToDouble(textBox25.Text);
        double cost25 = Math.Round(25.0 / rend50 * (precio_diesel + precio_dep) + 25.0 / rend_descargado * (precio_diesel + precio_dep), 2);
        textBox31.Text = cost25.ToString();
    }

    // Costo mas del 50% Retorno 0 CIUDAD
    private void textBox32_TextChanged(object sender, EventArgs e)
    {
        double rend_descargado = Convert.ToDouble(textBox26.Text);
        double rend100 = Convert.ToDouble(textBox29.Text);
        double precio_diesel = Convert.ToDouble(textBox24.Text);
        double precio_dep = Convert.ToDouble(textBox25.Text);
        double cost25 = Math.Round(25.0 / rend100 * (precio_diesel + precio_dep) + 25.0 / rend_descargado * (precio_diesel + precio_dep), 2);
        textBox32.Text = cost25.ToString();
    }

    // Costo total al 25%
    private void textBox35_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox23.Text);
        double costo25_retorno = Convert.ToDouble(textBox30.Text);
        double costo_operario = Convert.ToDouble(textBox33.Text);
        double costo_comida = Convert.ToDouble(textBox34.Text);
        double costo25 = Math.Round(trayectoria * (costo25_retorno + costo_operario + costo_comida), 2);
        textBox35.Text = costo25.ToString();
    }

    // Costo total al 50%
    private void textBox36_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox23.Text);
        double costo50_retorno = Convert.ToDouble(textBox31.Text);
        double costo_operario = Convert.ToDouble(textBox33.Text);
        double costo_comida = Convert.ToDouble(textBox34.Text);
        double costo50 = Math.Round(trayectoria * (costo50_retorno + costo_operario + costo_comida), 2);
        textBox36.Text = costo50.ToString();
    }

    // Costo total mas del 50%
    private void textBox37_TextChanged(object sender, EventArgs e)
    {
        double trayectoria = Convert.ToDouble(textBox23.Text);
        double costo100_retorno = Convert.ToDouble(textBox32.Text);
        double costo_operario = Convert.ToDouble(textBox33.Text);
        double costo_comida = Convert.ToDouble(textBox34.Text);
        double costo100 = Math.Round(trayectoria * (costo100_retorno + costo_operario + costo_comida), 2);
        textBox37.Text = costo100.ToString();
    }

    // Cobrar 25%
    private void textBox38_TextChanged(object sender, EventArgs e)
    {
        double ganancia = Convert.ToDouble(textBox44.Text) / 100;
        double costo_total25 = Convert.ToDouble(textBox35.Text);
        double cobrar25 = Math.Round(costo_total25 / (1 - ganancia), 2);
        textBox38.Text = cobrar25.ToString();
    }

    // Cobrar 50%
    private void textBox39_TextChanged(object sender, EventArgs e)
    {
        double ganancia = Convert.ToDouble(textBox44.Text) / 100;
        double costo_total50 = Convert.ToDouble(textBox36.Text);
        double cobrar50 = Math.Round(costo_total50 / (1 - ganancia), 2);
        textBox39.Text = cobrar50.ToString();
    }

    // Cobrar 100%
    private void textBox40_TextChanged(object sender, EventArgs e)
    {
        double ganancia = Convert.ToDouble(textBox44.Text) / 100;
        double costo_total100 = Convert.ToDouble(textBox37.Text);
        double cobrar100 = Math.Round(costo_total100 / (1 - ganancia), 2);
        textBox40.Text = cobrar100.ToString();
    }

    // Costo total 25% con descuento 
    private void textBox41_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double costo25 = Convert.ToDouble(textBox38.Text);
        double costo_dsc25 = Math.Round(costo25 * (1.0 - (dsc / 100)), 2);
        textBox41.Text = costo_dsc25.ToString();
    }

    // Costo total 50% con descuento
    private void textBox42_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double costo50 = Convert.ToDouble(textBox39.Text);
        double costo_dsc50 = Math.Round(costo50 * (1 - (dsc / 100)), 2);
        textBox42.Text = costo_dsc50.ToString();
    }

    // Costo total 100% con descuento
    private void textBox43_TextChanged(object sender, EventArgs e)
    {
        double dsc = Convert.ToDouble(textBox19.Text);
        double costo100 = Convert.ToDouble(textBox40.Text);
        double costo_dsc100 = Math.Round(costo100 * (1 - (dsc / 100)), 2);
        textBox43.Text = costo_dsc100.ToString();
    }

    // Costo operario
    private void textBox33_TextChanged(object sender, EventArgs e)
    {
        string costo_comida = textBox33.Text;
        if (!double.TryParse(costo_comida, out double d))
        {
            textBox33.Text = "0";
        }
        disable_all();
    }

    // Costo comida
    private void textBox34_TextChanged(object sender, EventArgs e)
    {
        string costo_comida = textBox34.Text;
        if (!double.TryParse(costo_comida, out double d))
        {
            textBox34.Text = "0";
        }
        disable_all();
    }

    // Radio button Camion
    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        textBox11.Text = "25.60";
        textBox8.Text = "23.04";
        textBox9.Text = "17.92";
        textBox10.Text = "14.40";

        textBox26.Text = "17.92";
        textBox27.Text = "16.13";
        textBox28.Text = "12.54";
        textBox29.Text = "10.08";

        disable_all();
    }

    // Radio Button Automovil
    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        textBox11.Text = "50.0";
        textBox8.Text = "0";
        textBox9.Text = "0";
        textBox10.Text = "30.0";

        textBox26.Text = "50.0";
        textBox27.Text = "0";
        textBox28.Text = "0";
        textBox29.Text = "30.0";
        
        disable_all();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void textBox44_TextChanged(object sender, EventArgs e)
    {
        string ganancia = textBox44.Text;
        if (!double.TryParse(ganancia, out double d))
        {
            textBox44.Text = "30.0";
        }
        disable_all();
    }
}




