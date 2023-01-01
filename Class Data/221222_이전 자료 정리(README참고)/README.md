# cho_study
# first_commit

git bash, sourcetree 설치
github 아이디 만들기
리포지토리 만들기(여기다 다 넣을 것)
(만든 직후 페이지를 찾아보면 README.md 파일을 작성하기 쉽게 해준다.)
.gitignore 파일 생성 git에 올릴 파일을 제한할 때 사용(디버그 실행 파일 등이 올라가면 용량이 너무 커진다.)
ㄴ(https://www.toptal.com/developers/gitignore/ 에서 Csharp 검색해서 텍스트 복사 후 확장자 없는 텍스트 파일 생성)

git 최초설정 참고 자료:
https://git-scm.com/book/ko/v2/%EC%8B%9C%EC%9E%91%ED%95%98%EA%B8%B0-Git-%EC%B5%9C%EC%B4%88-%EC%84%A4%EC%A0%95

* git 명령어

- 그 전에 로컬 디스크 C:에 자기 이름의 폴더를 만들고 내부에 폴더를 구분한 뒤 그 폴더에 우클릭 후 Git Bash Here

git clone 리포지토리링크: 리포지토리의 파일을 로컬 저장소에 복사 (git 설정 파일이 숨김 파일로 복사된다.)
(클론 이후에는 .git 설정파일이 있는 폴더를 우클릭하여 Git Bash Here 실행)
git config --global user.name "깃허브 닉네임"
git config --global user.email 따옴표없이 깃허브에 쓴 이메일
[아래는 업로드용]
git add . : 로컬 저장소에 복사된 파일 경로에 새로운 변경사항이 있다면 스테이지에 올린다. '.'은 파일 전체를 말한다.
git status : git 스테이지에 올라간 파일 체크
git commit -m "" : 스테이지에 올라간 파일에 메세지(-m)를 붙여 커밋한다.
git push origin main : 로컬 저장소의 메인 폴더 스테이지에 올라간 것을 git 리포지토리에 덮어쓴다.

* 비주얼 스튜디오 설치
최초 설치 시 '.NET 데스크톱 개발'/'Unity를 이용한 게임 개발' 체크해서 설치

* 프로젝트 만들기
C# 콘솔 앱 선택 -> 프로젝트 이름 설정, 위치를 git 폴더로 설정, ''솔루션 및 프로젝트를 같은 디렉터리에 배치' 체크
-> '최상위 문 사용 안 함' 체크 -> 솔루션 생성 후 솔루션 탐색기에서 C# 붙은 프로젝트 우클릭, 속성 
-> 전역 using에서 '암시적 전체 사용' 체크 해제 -> Program 파일 가장 위에 using System; 붙이기

* 추가 파일 만들기
솔루션 탐색기에서 프로젝트 우클릭 -> 추가 -> 새 항목 -> C# 클래스 생성
-> Main() 메서드 복사해서 새로운 C# 클래스에 생성
-> 솔루션 탐색기에서 이전 메인 메서드가 포함된 클래스 파일을 우클릭
-> 프로젝트에서 제외 클릭
(이제 새로운 파일로 콘솔이 실행된다!)

와이파이 비번: 024794050

경일 게임 아카데미 과정 공지사항 및 시간표(TMS)
http://kiweb.maniaro.com/

집체훈련 링크(LMS)
https://kgaonclass.lms.elice.io/

플밍 39기 질문 페이지(노션)
https://gray-ray-5ac.notion.site/39-41d49d79a279454f8ae302e6f77263c4
(로그인 해야함. 서식 수정하지 말 것.)

* 매일매일 블로그에 그 날 공부한 것 올리기
블로그 작성 시 참고 :
[김선준] [오전 10:26] https://kiveiru.tistory.com/

커밋컨벤션 참고 링크:
https://www.conventionalcommits.org/en/v1.0.0/

C# 교과서 공개 링크 :
https://thebook.io/006890/