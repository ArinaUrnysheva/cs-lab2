using System;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        //base.EditDocument();
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        //base.SaveDocument();
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        //base.SaveDocument();
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введите тип ключа доступа: exp или pro (если ключа доступа нет, введите слово 'нет'): ");
        string key = Console.ReadLine();
        if (key == "нет")
        {
            DocumentWorker worker = new DocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }

        else
        {
            if (key == "pro")
            {
                ProDocumentWorker worker = new ProDocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }

            else
            {
                if (key == "exp")
                {
                    ExpertDocumentWorker worker = new ExpertDocumentWorker();
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                }

                else
                {
                    Console.WriteLine("Некорректный тип ключа доступа.");
                }
            }
        }
    }
}