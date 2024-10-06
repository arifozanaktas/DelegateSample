using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample;

public delegate int MathExamDelegate(int x, int y);
public class MathExam
{
    
    public int MathExams(int a,int b, MathExamDelegate mathExamDelegate)
    {
        return mathExamDelegate(a,b);
    }
}
