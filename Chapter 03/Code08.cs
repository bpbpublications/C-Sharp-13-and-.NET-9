var isDirectory = true;
var myFile = new FileInfo("C:\\temp\\file.txt");
var myCondition = 0;

switch (isDirectory)
{
    case true when myFile != null && myCondition == 0:
        // Do somenthing when isDirectory is true
        // and myFile is
        // different from null
        // and myCondition is equals 0
        break;
    case true when myCondition == 1 // Do somenthing when isDirectory is true
        // and myCondition is equals 1
        break;
    case false:
    // Do something is isDirectory is false
    default:
// Do something if isDirectory is true
// and myFile is null or myCondition
// is different than 0
}