//выводит полученные фрагменты изображения 
//и контролирует логику программы c помощью обработкчиков событий 
    public class   Form2 : Form
    { 
        PictureBox[] pm; // создается  массив контейнеров видимый для всех процедур класса form2
        bool status = false; // true - перетаскивается мышкой рисунок, false -  не перетаскивается.
        private int col_vo;//количество фрагментов пазла.
        private int minets;//счетчик минут
        private int seconds;//счетчик секунд
        public Form2(List<Image> x,int w, int h, int col_vo)
        {
        // List<Image> x - список изображений 
        // int w - ширина основного изображения
        // int h - высота основного изображения
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) 
        {//Метод-обработчик отпускания мыши  }

        private bool IsEnd()
        { 
            // каждый раз когда  опускается какое-то изображение, запускается проверка "а не конец игры ли это"
}
                Form5 f5 = new Form5(true, minets,seconds,col_vo);//обьект формы
  
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) 
        {
              / //Метод-обработчик задержки мыши
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) 
        {
//Метод-обработчик перемещения мыши            
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
//метод описывающий работу таймера
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
//обработчик кнопки выхода}}
