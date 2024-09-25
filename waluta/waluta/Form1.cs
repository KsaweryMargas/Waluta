namespace waluta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string vaule = textBox1.Text;

            textBox1.Text = vaule;
            float number = float.Parse(vaule);

            //PLN

            if (radioButton1.Checked && radioButton5.Checked)
            {
                label2.Text = (number * 1.0f).ToString();
                //PLN - PLN
            }

            if (radioButton1.Checked && radioButton6.Checked)
            {
                label2.Text = (number * 0.26f).ToString();
                //PLN - USD
            }
            if (radioButton1.Checked && radioButton7.Checked)
            {
                label2.Text = (number * 0.2344f).ToString();
                //PLN - EURO
            }
            if (radioButton1.Checked && radioButton8.Checked)
            {
                label2.Text = (number * 23.1f).ToString();
                //PLN - RUB
            }
            if (radioButton1.Checked && radioButton10.Checked)
            {
                label2.Text = (number * 37.60f).ToString();
                //PLN - JPY
            }

            //USD

            if (radioButton2.Checked && radioButton5.Checked)
            {
                label2.Text = (number * 3.81f).ToString();
                //USD - PLN
            }

            if (radioButton2.Checked && radioButton6.Checked)
            {
                label2.Text = (number * 1.0f).ToString();
                //USD - USD
            }
            if (radioButton2.Checked && radioButton7.Checked)
            {
                label2.Text = (number * 0.8952f).ToString();
                //USD - EURO
            }
            if (radioButton2.Checked && radioButton8.Checked)
            {
                label2.Text = (number * 92.41f).ToString();
                //USD - RUB
            }
            if (radioButton2.Checked && radioButton10.Checked)
            {
                label2.Text = (number * 142.9f).ToString();
                //USD - JPY
            }

            //EUR

            if (radioButton3.Checked && radioButton5.Checked)
            {
                label2.Text = (number * 4.26f).ToString();
                //EUR - PLN
            }

            if (radioButton3.Checked && radioButton6.Checked)
            {
                label2.Text = (number * 1.119f).ToString();
                //EUR - USD
            }
            if (radioButton3.Checked && radioButton7.Checked)
            {
                label2.Text = (number * 1.0f).ToString();
                //EUR - EUR
            }
            if (radioButton3.Checked && radioButton8.Checked)
            {
                label2.Text = (number * 103.4f).ToString();
                //EUR - RUB
            }
            if (radioButton3.Checked && radioButton10.Checked)
            {
                label2.Text = (number * 159.81f).ToString();
                //EUR - JPY
            }

            //RUB

            if (radioButton4.Checked && radioButton5.Checked)
            {
                label2.Text = (number * 0.0414f).ToString();
                //RUB - PLN
            }

            if (radioButton4.Checked && radioButton6.Checked)
            {
                label2.Text = (number * 0.016).ToString();
                //RUB - USD
            }
            if (radioButton4.Checked && radioButton7.Checked)
            {
                label2.Text = (number * 0.009672f).ToString();
                //RUB - EUR
            }
            if (radioButton4.Checked && radioButton8.Checked)
            {
                label2.Text = (number * 1.0f).ToString();
                //RUB - RUB
            }
            if (radioButton4.Checked && radioButton10.Checked)
            {
                label2.Text = (number * 1.568f).ToString();
                //RUB - JPY
            }

            //JPY

            if (radioButton9.Checked && radioButton5.Checked)
            {
                label2.Text = (number * 0.02649f).ToString();
                //JPY - PLN
            }

            if (radioButton9.Checked && radioButton6.Checked)
            {
                label2.Text = (number * 0.006935f).ToString();
                //JPY - USD
            }
            if (radioButton9.Checked && radioButton7.Checked)
            {
                label2.Text = (number * 0.006206f).ToString();
                //JPY - EUR
            }
            if (radioButton9.Checked && radioButton8.Checked)
            {
                label2.Text = (number * 0.6378f).ToString();
                //JPY - RUB
            }
            if (radioButton9.Checked && radioButton10.Checked)
            {
                label2.Text = (number * 1.0f).ToString();
                //JPY - JPY
            }
        }
    }
}
