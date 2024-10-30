# csharpcallbackgolang

c#에서 golang함수를 호출하는데, 델리게이트를 인자로 넣어 invoke합니다.

## How to run

그냥 다 깔린 코드스페이스에서 실행한다는 기준입니다.

```bash
go version # go version go1.23.1 linux/amd64
dotnet --version # 8.0.402
go mod init csharpcallbackgolang
go build -o build/csharpcallbackgolang.so -buildmode=c-shared
dotnet publish -o build
./build/csharpcallbackgolang # Hello from C# delegate!
```

## Thanks

- copilot
- https://stackoverflow.com/questions/70481474/calling-c-function-pointer-as-callback-from-go-code

## 도보시오

- https://github.com/monkey0506/native-generic-delegates
- https://github.com/johncburns1/Golang-.NET-SharedC
- https://github.com/GridProtectionAlliance/go2cs
- rust ffi cgo etc..
