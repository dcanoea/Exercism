import java.util.ArrayList;
import java.util.List;

public class LanguageList {
    private final List<String> languages = new ArrayList<>();

    public boolean isEmpty() {
        int size = languages.size();
        if(size == 0) {
            return true;
        }else{
            return false;
        }
    }

    public void addLanguage(String language) {
        languages.add(language);
    }

    public void removeLanguage(String language) {
        languages.remove(language);
    }

    public String firstLanguage() {
        String first = languages.get(0);
        return first;
    }

    public int count() {
        int countLanguages = languages.size();
        return countLanguages;
    }

    public boolean containsLanguage(String language) {
        if (languages.contains(language)){
            return true;
        }else {
            return false;
        }
    }

    public boolean isExciting() {
        if (languages.contains("Java") || languages.contains("Kotlin")){
            return true;
        }else {
            return false;
        }
    }
}
