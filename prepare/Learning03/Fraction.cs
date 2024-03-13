public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom=1;

    }

    public Fraction(int _wholeNumber){
        _top = _wholeNumber;
        _bottom=1;
    }

     public Fraction(int _top, int _bottom){
        this._top = _top;
        this._bottom = _bottom;
    }

    public int getTop(){
        return _top;
    }

    public void setTop(int _top){
        this._top = _top;
    }

    
    public int getBottom(){
        return _bottom;
    }

    public void setBottom(int _bottom){
        this._bottom = _bottom;
    }

    public string getFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double getDecimalValue(){
        return (double) _top/_bottom;
    }


}