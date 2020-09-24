# XML.NET

## 목표
 - `XmlReader` (`A-XmlReader`)
 - `XmlWriter` (`B-XmlXmlWriter`)
 - `XmlTextReader` + `XmlTextWriter` (`C-XmlTextReader`)
 - `XmlDOM` (`D-XmlDOM`)

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


## Tip: 경로 관련 오류

```cs
...
        public static void Main(string[] args)
        {
            using(XmlReader reader = XmlReader.Create(@"book1.xml"))
            {
               while(reader.Read())
               {
                 ...
               }
            }
        }
    }
}
```

```bash
처리되지 않은 예외: System.IO.FileNotFoundException...
```

#### 문제 분석
 - 원인: 파일이 해당 폴더 안에 없기 떄문에 발생한 오류입니다.  해당 프로젝트 내에서 경로지정을 파일만 호출한다면 해당파일의 위치는 `솔루션` -> `프로젝트` -> `bin` -> `Debug` 폴더 안을 먼저 찾습니다.
 - 해결방법: 파일의 위치가 `Debug` 폴더가 아닌 위치에 있을 경우는 주소를 경로에 맞추어 변경해 주세요. 예를 들면 `솔루션` -> `프로젝트` 폴더와 같이 상위의 상위폴더라면 `XmlReader.Create(@"..\..\book1.xml")`로 바꾸어주세요. `..\`은 상위 폴더를 의미합니다.
