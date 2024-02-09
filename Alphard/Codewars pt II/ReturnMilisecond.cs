//Function to return milisecond

  using System;
  public static class Clock
  {
    public static int Past(int h, int m, int s)
    {
      //#Happy Coding! ^_^
      int result = (h * 3600000) + (m * 60000) + (s * 1000);
      return result;
    }
  }
