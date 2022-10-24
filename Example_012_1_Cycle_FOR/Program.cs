string Method4(int count, string text)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    //int i = 0 - инициализация счетчика
    //i < count - проверка условия
    //i++ - инкримент или увеличение счетчика
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "New Text ");
Console.WriteLine(res);
//Цикл for аналогичен циклу while но более удобен в использовании, т.к. все данные вводятся в одном месте.