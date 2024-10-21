using System;

public class ClassRoom
{
    private Pupil[] pupils;
    public ClassRoom(params Pupil[] pupils)
    {
        if(pupils.Length < 2 || pupils.Length > 4)
        {
            throw new ArgumentException("Amount of pupils is from 2 to 4.");
        }
        this.pupils = pupils;
    }

    public void ShowPupilsSkills()
    {
        foreach(var pupil in pupils)
        {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}

public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("The pupil is studying");
    }

    public virtual void Read()
    {
        Console.WriteLine("The pupil is reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("The pupil is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("The pupil is relaxing");
    }
}

public class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("The pupil is studying excellent");
    }

    public override void Read()
    {
        Console.WriteLine("The pupil is reading excellent");
    }

    public override void Write()
    {
        Console.WriteLine("The pupil is writing excellent");
    }

    public override void Relax()
    {
        Console.WriteLine("The pupil is relaxing excellent");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("The pupil is studying good");
    }

    public override void Read()
    {
        Console.WriteLine("The pupil is reading good");
    }

    public override void Write()
    {
        Console.WriteLine("The pupil is writing good");
    }

    public override void Relax()
    {
        Console.WriteLine("The pupil is relaxing good");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("The pupil is studying bad");
    }

    public override void Read()
    {
        Console.WriteLine("The pupil is reading bad");
    }

    public override void Write()
    {
        Console.WriteLine("The pupil is writing bad");
    }

    public override void Relax()
    {
        Console.WriteLine("The pupil is relaxing bad");
    }
}
class Programm
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new ExcellentPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.ShowPupilsSkills();
    }
}