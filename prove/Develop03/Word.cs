public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string _text){
        this._text = _text;
        _isHidden = false;
    }

    public void hide(){
        _isHidden = true;
    }

    public void show(){
        _isHidden = false;
    }

    public bool isHidden(){
        return _isHidden;
    }

    public string getDisplayText(){
        return _text;
    }
}