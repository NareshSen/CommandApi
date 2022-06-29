namespace CommandAPI.Models
{

public class Command 
{
[Key]
[Required]
public int ID {get;set;}  
[Required]
[MaxLength(250)]
public string HowTo {get;set;}
[Required]
public string Plateform{get;set;}
[Required]
public string CommandLine {get;set;}

}




}