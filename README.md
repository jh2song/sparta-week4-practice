# 카드 퍼즐 게임
## 소개
이 프로젝트는 짝 맞추기 카드 게임입니다. 제한 시간(60초) 안에 4x4 카드들의 짝을 맞춰서 카드를 없애고 모든 카드를 없애는것이 게임의 목표입니다.

[유튜브 시연 영상](https://www.youtube.com/watch?v=osfHgInEGrQ)
## 코드 설명
- [GameManager.cs](https://github.com/jh2song/sparta-week4-practice/blob/main/Assets/Scripts/GameManager.cs)
  - 싱글턴화를 해서 게임의 구조를 감쌉니다.
  - `Start` 메서드에서 카드들을 배치합니다.
  - `Update` 메서드에서 시간을 갱신하고 시간이 초과할 시 게임 오버를 제어합니다.
  - `IsMatched` 메서드에서 선택한 카드를 비교 후 같은 카드면 없애고 다른 카드면 다시 덮습니다.
- [Card.cs](https://github.com/jh2song/sparta-week4-practice/blob/main/Assets/Scripts/Card.cs)
  - `OpenCard` 메서드에서 연 카드를 게임 매니저의 첫 번째 카드 혹은 두 번째 카드로 할당합니다. (firstCard, secondCard)
  - 카드를 열때와 닫을때의 애니메이션 제어합니다.
- [EndTxt.cs](https://github.com/jh2song/sparta-week4-practice/blob/main/Assets/Scripts/EndTxt.cs)
  - 게임이 끝날때 활성화되는 오브젝트의 스크립트입니다.
  - `RetryGame` 메서드에서 다시 Scene을 로드합니다.
## 기술 스택
- Unity
- C#
- Rider
