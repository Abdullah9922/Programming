#include <bits/stdc++.h>
using namespace std;

int main() {
    int t;
    cin >> t;

    while(t--) {
        string s;
        cin >> s;

        string t = s;

        
        for(int i=0; i<s.size(); i++){

            int flag = 0;
            if(s[i] == t[i]){

                if(t[i] == '0'){
                    for(int j=i+1; j<s.size(); j++){ 
                    
                        if(t[j] == '1'){
                            swap(t[i],t[j]);
                            flag++;
                            break;
                        }

                        if(flag == 0 && j == s.size()){ // jodi khuje na pai?
                            cout << (((t.length())-i)+1) << endl;
                        }
                    }
                }

                else{
                    for(int j=i+1; j<s.size(); j++){ 
                    
                        if(t[j] == '0'){
                            swap(t[i],t[j]);
                            flag++;
                            break;
                        }

                        if(flag == 0 && j == s.size()){ // jodi khuje na pai?
                            cout << (((t.length())-i)+1) << endl;
                        }
                    }
                }
            }

        }


















        // int cnt[2] = {0, 0};

        // // Count number of 0s and 1s
        // for(char c : s) {
        //     cnt[c - '0']++;
        // }

        // for(int i = 0; i <= s.size(); i++) {

        //     if(i == s.size() || cnt[1 - (s[i] - '0')] == 0) {
        //         cout << s.size() - i << endl;
        //         break;
        //     }

        //     cnt[1 - (s[i] - '0')]--;
        // }
    }

    return 0;
}