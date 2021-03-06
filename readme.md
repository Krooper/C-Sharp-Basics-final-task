# Итоговая проверочная работа

**Задание**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
1. ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
2. ["1234", "1567", "-2", "computer science"] -> ["-2"]
3. ["Russia", "Denmark", "Kazan"] -> []

## Комментарии:

* Несоклько веток - отдельные для: самой программы (основная), редактирования файла readme, редактирования файлы с блок-схемой. Каждая ветка будет иметь несоклько коммитов, в итоге - слияние всех веток в main.
* Т.к. при постановке задачи был дан выбор, как заполнять исходный массив, остановлюсь на варианте с уже заданным изначально массивом (кол-во элементов - случайное в диапазоне от 1 до 10) во избежание возможных проблем при вводе с клавиатуры.
* Блок-схема основной части (основного метода) программы (см. п. 2 ниже) находится в отдельном файле - diagram.drawio.png.

### Описание работы программы
1. Задача исходной строки - отдельный метод. Кол-во элементов массива - случайное (в диапазоне от 1 до 10 включительно). Элементы массива - строки, конкретно: повторяющиеся символы "*". Кол-во повторений символа в одной строке - случайное (в диапазоне от 1 до 5 включительно). Метод возвращает одномерный массив строк.
2. Отдельный метод для определения элементов массива, длина которых меньше или равна 3 символам. Метод принимает на вход одномерный массив строк, обходит его в цикле. Перед ним создаем новый массив строк с аналогичной длиной, в процессе обхода исходного массива заменяет элементы (путые строки) в новом массиве на подходящие под условия. По окнчанию, удаляем лишние элементы. Метод в итоге возвращает также одномерный массив строк.
3. Отдельный метод для печати (вывода в консоль) обоих получившихся массивов. Формат печати аналогичен примерам, а именно: [первый массив] -> [второй массив].
