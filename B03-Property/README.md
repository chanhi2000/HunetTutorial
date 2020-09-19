# Property  

## 목표
 - 프로퍼티 접근 (`A-Property`)
 - 인덱서 생성 및 접근 (`B-Indexer`)
 - 인터페이스 인덱서 (`C-InterfaceIndexer`)

## 인덱서 와 프로퍼티의 차이

|속성(Property)|인덱서(Indexer)|
|:-----------:|:-----------:|
|공용 데이터 멤버인 것처럼 메소드를 호출 할 수 있음|개체 자체의 배열 표기법을 사용해 개체의 컬랙션 요소에 엑세스 할 수 있음.|
|단순한 이름을 통해 엑세스 할 수 있음|인덱스를 통해 엑세스 할 수 있음|
|정적 또는 인스턴스 멤버가 될 수 있음|인스턴스 멤버여야 함|
|속성의 접근자에는 매개 변수가 없음|인덱서 `get` 접근자는 인덱서와 동일한 정식 매개변수 목록을 가짐|
|속성의 접근자에는 명시적인 value 매개변수가 포함됨|인덱서와 `set` 접근자는 매개변수 외에도 인덱서와 동일한 정식 매개변후 목록을 가짐|
|약식구문을 지원함|약식구문을 지원하지 않음|


## `dotnet` 실행어

### `dotnet new sln`
솔루션 서식 생성

### `dotnet sln add ...${프로젝트이름}.csproj`
솔루션에 프로젝트 추가 

### `dotnet build ${SLN파일}.sln`
솔루션에 모두 포함되어 있는 대상 모듈 컴파일 후 실행 

### `dotnet new console`
콘솔용 애플리케이션 생성

### `dotnet run`
컴파일 후 실행

### `*.csproj` 파일에서 컴파일 대상에서 제외

```xml
...
  <ItemGroup>
    <Compile Remove="InheritEx1.cs" />
    ...
  </ItemGroup>

  <ItemGroup>
    <None Include="InheritEx1.cs" />
    ...
  </ItemGroup>
...
```


## Tip: 접근 지정자 관련 오류

```cs
...
        private set
        {
            name[index % 5] = value;
        }
    }
}
class MTest
{
    public static void Main(string[] args)
    {
        InTest s = new InTest();
        s[0] = "Hong";
        s[9] = "Park";
        Console.WriteLine("{0}", s[0]);
        Console.WriteLine("{1}", s[4]);
...
```

```bash
set 접근자에 엑세스할 수 없으므로 `프로퍼티인덱서.InTest.this[int]` 속성 또는 인덱서는 이 컨텍스트에서 사용할 수 없습니다.
```

#### 문제 분석0
 - 오류 : 20줄에 선언된 `private`로 31~32줄에서 값을 저장할 수 없습니다. 속성의 접근제한자가 `private`으로 선언되면 은닉화 상태기 때문입니다.
 - 해결방법 : 값을 저장하려면 접근지정자를 `default`또는 `public`으로 선언하시면 됩니다.
 

