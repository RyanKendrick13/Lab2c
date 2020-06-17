using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a color");
    var color  = Console.ReadLine();
    switch(color){
      case "red":
      Console.WriteLine("The color red is warm");
      break;
      case "yellow":
      Console.WriteLine("The color yellow is warm");
      break;
      case "orange":
      Console.WriteLine("The color orange is warm");
      break;
      case "gold":
      Console.WriteLine("The color gold is warm");
      break;
      case "pink":
      Console.WriteLine("The color pink is warm");
      break;
      case "blue":
      Console.WriteLine("The color blue is cool");
      break; 
      case "magenta":
      Console.WriteLine("The color magenta is cool");
      break;
      case "green":
      Console.WriteLine("The color green is cool");
      break;
      case "purple":
      Console.WriteLine("The color purple is cool");
      break;
      case "black":
      Console.WriteLine("The color black is neutral");
      break;
      case "white":
      Console.WriteLine("The color white is neutral");
      break;
      case "ivory":
      Console.WriteLine("The color ivory is neutral");
      break; 
      case "brown":
      Console.WriteLine("The color brown is neutral");
      break; 
      case "beige":
      Console.WriteLine("The color beige is neutral");
      break;
      default:
      Console.WriteLine("Unable to determine the color temperature for the color"+ " "+ color);
      break;

      
     
      
      
    }

  }
}