using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool capitalizeNext = false;
        foreach (char c in identifier){
            if(char.IsWhiteSpace(c)){
                sb.Append('_');
            }else if(char.IsControl(c)){
                sb.Append("CTRL");
            }else if(c=='-'){   
                capitalizeNext = true;
            }else if(char.IsLetter(c)){
                if(capitalizeNext){
                    sb.Append(char.ToUpper(c));
                    capitalizeNext = false;
                }else if (c >= '\u03B1' && c <= '\u03C9'){
                    continue;
                }else{
                    sb.Append(c);
                }
            }
        }
        return sb.ToString();
    }
}
