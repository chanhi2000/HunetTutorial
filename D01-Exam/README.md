# CharPro

Char구조체의 메소드를 활용하여 조건에 맞게 프로그램을 작성하고, 파일 입출력을 구현하는 문제를 조건에 맞게 프로그램 작성하시오 (50점)

## 1. Char구조체의 메소드

### [조건 A] 구현 클래스 

|project명|class명|method명|설명|
|:------:|:-----:|:-------|:---|
|`CharPro`|`CharPro`|`static void Main(string[] args)`|`Console.read()`로 문자를 입력받아 `if`와 `Char` 구조체의 메서드를 사용해서 입력 문자가 대문자인지, 소문자인지 또는 숫자인지 검사하고 그렇지 않으면 “입력 문자는 기타등등입니다.”를 출력한다. |

### [조건 B] 실행 결과

![imgA][imgA]


## 2. 파일 입출력 구현

|project명|class명|method명|설명|
|:------:|:-----:|:-------|:---|
|`StreamPro`|`StreamPro`|`static void Main(string[] args)`|`Output()`메서드와 `Input()`메서드를 호출한다 |
|`StreamPro`|`StreamPro`|`void Input()`|"TestFile.txt"의 내용을 읽어 화면에 출력한다.|
|`StreamPro`|`StreamPro`|`void output()`|"TestFile.txt"를 만들어 내용을 저장한다.|

> TestFile.txt의 내용

```
봄 여름 가을 겨울의 사계절 중 난 겨울이 가장 좋습니다.

현재 시간은 2012-09-06 오후 6:54:20입니다
```

### 조건
- `using`구문을 사용해서 `StreamReader`, `StreamWriter`를 생성한다. 
- 파일에 입출력 되는 현재 시간을 `DateTime` 구조체를 사용한다.

### [조건 B] 실행 결과

![imgB][imgB]


[imgA]: imgs/A.png
[imgB]: imgs/B.png

