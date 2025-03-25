스파르타 던전 - Unity  버전 (인벤토리)

이전에 했던 c# 구현 내용을 유니티로 옮기는 내용입니다.
배웠던 내용이 실제로 유니티에서 어떻게 적용되는지 직접 구현하며 연습해봅시다.

- **STEP 1. UI 구성하기**
    
    **[목표]** : **UGUI를 활용해 UIMainMenu, UIStatus, UIInventory 구성을 완료**
    
    - UIMainMenu, UIStatus, UIInventory → 각각 Canvas로 만들기
        - 각 UI의 하위에 예시 스크린샷을 참고해서 UI를 구성하기
    - (임의의 스프라이트 이미지 활용)
- **STEP 2. 스크립트 만들기**
    
    **[목표]** : **필요한 스크립트를 모두 만들고, UIManager에 연결, Character 클래스 작성**
    
    - 필요한 스크립트를 만들어 주기
        - GameManager, UIManager, UIMainMenu, UIStatus, UIInventory, Character
            - → UI 스크립트들에는 하부 UI 구성요소에 해당하는 필드모두 추가
    - UIManager 스크립트에 [SerializedField]를 활용하여 3개의 UI를 연결
    - Character 클래스에 캐릭터 데이터를 작성
        - 필요한 필드 및 생성자 작성
- **STEP 3. UI 간 전환 기능 만들기**
    
    **[목표]** : **UIManager를 통해 각 UI에 접근하고, 버튼 클릭 시 각 UI 열기/뒤로가기 기능 추가**
    
    - UIMainMenu의 스크립트를 작성합니다.
        - OpenMainMenu, OpenStatus, OpenInventory 메서드 추가.
    - UIManager 업그레이드
        - 싱글톤으로 만들기
        - UIMainMenu, UIStatus, UIInventory 프로퍼티로 만들기
    - UIMainMenu 메서드 내용 작성
        - UIManager를 통해 각 UI에 접근해서 켜기
    - 버튼 추가하기
        - 각 UI의 Start() 메서드에 AddListener를 활용해서 추가
- **STEP 4. 캐릭터 정보 세팅하기**
    
    **[목표] : Player 정보가 따라 UIMainMenu, UIStatus에 보여짐**
    
    - Character 클래스의 필드를 {get; private set;}으로 만들기
    - UIMainMenu, UIStatus 클래스에 Chracter 정보를 세팅하는 메서드 추가
        - 보간문자열을 활용하여 각 UI에 캐릭터 정보가 표시
    - GameManager 스크립트 작성
        - player 프로퍼티 추가
        - SetData() 메서드를 만들기
            - 생성자를 통해 Player 생성하면서 Player에 데이터를 넣기
            - 각 UI에 작성된 Character 정보를 세팅하는 메서드에 Player 인자로 전달
              
- **STEP 5. UISlot 동적 생성하기**
    
    **[목표]** **: 인벤토리에 스크롤뷰 추가 및 스크롤 뷰에 슬롯이 동적으로 생성됨**
    
    - UISlot 구성하기
        - UISlot을 스크린샷을 보고 UGUI 활용해 구성
        - UIInventory에 스크롤 뷰 구성
    - UISlot 스크립트 작성
        - UISlot 스크립트 추가하고, UI 구성요소에 연결될 필드 추가(SerializedField)
        - SetItem(), RefreshUI() 메서드 추가
    - UIInventory 스크립트 작성
        - UISlot 타입의 필드 추가 → UISlot 프리팹 추가
        - UISlot 타입의 리스트 추가
        - Trasnform 타입의 slot 부모 추가
        - InitInventoryUI() 메서드 작성 → Start()에서 호출
            - UISlot 리스트, for문, Instantiate 등등 활용
              
- **STEP 6. Item 데이터 준비하기**
    
    **[목표] : 보여질 아이템 스크립트 완성**
    
    - Item 스크립트 작성
        - 관련 필드 및 프로퍼티, 생성자 작성
    - Character 스크립트 수정
        - Item 타임의 리스트 Inventory 추가
        - Character 생성자에 Inventory 추가
        - Additem, Equip, UnEquip 메서드 추가 및 내용 작성
    - GameManager 스크립트 수정
        - SetData 메서드에 아이템 생정자를 통해 데이터 추가

***________7&8 Task는 최대한 힌트 없이 완성__________***

- **STEP 7. 아이템 장착**
    
    **[목표]** : **인벤토리에 아이템 장착 및 해제 표시가 보여짐**
    
    - UIInventory 스크립트 완성
    - UISlot 스크립트 완성
- **STEP 8. Status에 아이템 정보 반영**
    
    **[목표] : Status에 장착한 아이템 정보가 반영됨**
    
    - Character 스크립트 완성
    - UIStatus 스크립트 완성
    - GameManager 스크립트 완성
