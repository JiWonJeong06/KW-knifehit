using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WeaponLoader : MonoBehaviour
{
    // 무기 데이터 구조 정의
    [System.Serializable]
    public class WeaponData
    {
        public int ID;
        public string Name;
        public string Rare;
        public List<float> Levels;

        public WeaponData(int id, string name, string rare, List<float> levels)
        {
            ID = id;
            Name = name;
            Rare = rare;
            Levels = levels;
        }
    }

    // 무기 리스트 저장
    public List<WeaponData> weaponList = new List<WeaponData>();

    void Start()
    {
        LoadCSV();
      
    }

    void LoadCSV()
    {
        // Resources 폴더에 있는 Data_Table_Knife.csv 파일 불러오기
        TextAsset csvData = Resources.Load<TextAsset>("Data_Table_Knife");

        if (csvData == null)
        {
            Debug.LogError("CSV 파일을 찾을 수 없습니다! Resources 폴더에 Data_Table_Knife.csv가 있는지 확인하세요.");
            return;
        }

        StringReader reader = new StringReader(csvData.text);
        bool isFirstLine = true;

        while (true)
        {
            string line = reader.ReadLine();
            if (line == null) break;

            if (isFirstLine)
            {
                isFirstLine = false;
                continue; // 헤더 건너뛰기
            }

            string[] values = line.Split(',');

            if (values.Length < 4) continue;

            int id = int.Parse(values[0]);
            string name = values[1];
            string rare = values[2];

            List<float> levels = new List<float>();
            for (int i = 3; i < values.Length; i++)
            {
                if (float.TryParse(values[i], out float val))
                    levels.Add(val);
                else
                    levels.Add(0f); // 파싱 실패 시 0으로 대체
            }

            WeaponData weapon = new WeaponData(id, name, rare, levels);
            weaponList.Add(weapon);
        }

    }

}
