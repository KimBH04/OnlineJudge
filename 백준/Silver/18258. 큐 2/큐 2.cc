#include <iostream>
#include <string>
#include <queue>
using namespace std;

int main(){
    ios_base::sync_with_stdio(0);
    cin.tie(NULL);
    cout.tie(NULL);

    int n;
    queue<int> q;
    cin >> n;

    while (n--){
        string command;
        cin >> command;

        if (command == "push"){
            int x;
            cin >> x;
            q.push(x);
        }
        else if (command == "pop"){
            if (q.empty()){
                cout << -1 << "\n";
                continue;
            }
                
            cout << q.front() << "\n";
            q.pop();
        }
        else if (command == "size"){
            cout << q.size() << "\n";
        }
        else if (command == "empty"){
            cout << (int)q.empty() << "\n";
        }
        else if (command == "front"){
            if (q.empty()){
                cout << -1 << "\n";
                continue;
            }
            
            cout << q.front() << "\n";
        }
        else if (command == "back"){
            if (q.empty()){
                cout << -1 << "\n";
                continue;
            }

            cout << q.back() << "\n";
        }
    }

    return 0;
}