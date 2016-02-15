public class Form3 : Form
    {
        {

            radioButton1.MouseClick += radioButton1_MouseClick;
            label1.MouseClick += radioButton1_MouseClick;
            radioButton2.MouseClick += radioButton2_MouseClick;
            label2.MouseClick += radioButton2_MouseClick;
            radioButton3.MouseClick += radioButton3_MouseClick;
            label3.MouseClick += radioButton3_MouseClick;
//привязка к элементам формы имеющихся обработчиков нажатия на них.
        }

        private int col_vo;//определяется  поле для расчета количества пазлов.

        void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
//обработчик нажатия кнопки выбора режима игры - легкий
        }

        void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
//обработчик нажатия кнопки выбора режима игры - средний        }    

        void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {  
//обработчик нажатия кнопки выбора режима игры - сложный}



        private void button1_Click(object sender, EventArgs e)
        {
            //обработчик нажатия кнопки старт
           
        }

}
