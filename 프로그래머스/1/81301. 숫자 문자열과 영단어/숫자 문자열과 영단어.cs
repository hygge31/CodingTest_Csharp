using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        Word[] words = new Word[]{
            new Word("zero","0"),
             new Word("one","1"),
             new Word("two","2"),
             new Word("three","3"),
             new Word("four","4"),
             new Word("five","5"),
             new Word("six","6"),
            new Word("seven","7"),
            new Word("eight","8"),
            new Word("nine","9"),
        };
    
        for(int i = 0 ; i<words.Length;i++){
            if(s.Contains(words[i].word)){
                s = s.Replace(words[i].word,words[i].num);
            }
        }
        
        return answer = int.Parse(s);
    }
}

public struct Word{
    public string word;
    public string num;
    
    public Word(string word,string num){
        this.word = word;
        this.num = num;
    }
}