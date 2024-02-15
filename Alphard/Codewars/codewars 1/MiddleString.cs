public class Kata
{
  public static string GetMiddle(string s)
  {
    int length = (int)s.Length;
    
    if(length % 2 == 0) {
       int middle = length / 2;
       return s.Substring(middle - 1, 2);
    } else 
      {
      int middle = length / 2;
      return s.Substring(middle, 1 );
    }
  }
}