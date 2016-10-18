namespace Ceasar
{
    public class ErrorMessage
    {
        public static string IsNullOrEmptyErrorMessage
        {
            get
            {
                return "Error: input is null or empty";
            }
        }
        public static string CannotReadFromFile
        {
            get
            {
                return "Error: cannot read from file. Please check if the file exists.";
            }
        }
        public static string CannotWriteToFile
        {
            get
            {
                return "Error: cannot write to file. Please check if path is correct.";
            }
        }
    }
}
