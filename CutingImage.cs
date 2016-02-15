//Основной класс,получающий изображение и масштабирующий его до конкретного числа пикселей. 
//Далее используя классы form2 и form3 режет изображиение на количество 
//фрагментов определенных сложностью игры и выводит фрагменты на экран.
public class CutingImage : ResizingImage
    {
  /// Выводит изображение, режет на части ,сохраняет в список и выводит в форме 2
 public void CutImage(PictureBox pictureBox1, Type form2, int col_vo){ 
}     
                // создаем объект 2 формы 
                // при создании объекта класса запускается конструктор класса 
                // конструктор класса form2 принимает параметры 
                // первый параметр - список картинок 
                // второй параметр - ширина изначального изображения
                // третий параметр - высота изображения

                var _form2 = form2.GetConstructor(new Type[] { typeof(List<Image>), typeof(int), typeof(int), typeof(int) }).Invoke(new object[] { list, src.Width, src.Height, col_vo });

                form2.GetMethod("Show", new Type[] { }).Invoke(_form2, new object[] { });

}
}
