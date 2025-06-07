var myExpression = "A";

switch (myExpression)
{
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        // Code to be executed if myExpression
        // matches these values
        break;
    case "W":
    case "Y":
        // Code to be executed if myExpression
        // matches W or Y
        break;
    // ...
    default:
        // Code to be executed if myExpression
        // doesn't match any case
        break;
}