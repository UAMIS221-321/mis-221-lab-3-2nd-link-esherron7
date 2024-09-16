//begin main


string enjoymentLevel=GetEnjoymentLevel();
string stadium=GetStadiumRecommendation(enjoymentLevel);

if (stadium=="unknown"){
    System.Console.WriteLine("Invalid menu choice.");
}
else{
    string game=GetGameRecommendation(stadium);
    DisplayStadiumDetails(stadium, game);
}
//end main

static string GetEnjoymentLevel()
{
    System.Console.WriteLine("What is your desired level of enjoyment?");
    return Console.ReadLine().ToLower();
    
}

static string GetStadiumRecommendation(string enjoymentLevel)
{
    string stadium="";

    switch(enjoymentLevel){
        case "boring":
        stadium="Neyland Stadium";
        break;
    case "average":
        stadium="Jordan-Hare Stadium";
        break;
    case "fun":
        stadium="Tiger Stadium";
        break;
    case "epic":
        stadium="Saban Field at Bryant Denny Stadium";
        break;
    default:
        
        stadium="unknown";
        break;
    }
    return stadium;
}
static string GetGameRecommendation(string stadium){
    string game="";

    switch(stadium){
    case "Neyland Stadium":
        game="vs Kent State";
        break;
     case "Jordan-Hare Stadium":
        game="vs Kentucky";
        break;
    case "Tiger Stadium":
        game="vs Alabama";
        break;
    case "Saban Field at Bryant Denny Stadium":
        game="vs Auburn";
        break;
    default:
        System.Console.WriteLine("No game available.");
        game="unknown";
        break;

    } 
    return game;
    }
static void DisplayStadiumDetails(string stadium, string game){
    
    System.Console.WriteLine($"The best Stadium and Game for you to attend based on our reccommendation, is a game at {stadium} {game}.");
}


    