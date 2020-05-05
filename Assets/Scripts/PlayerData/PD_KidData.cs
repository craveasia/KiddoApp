using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PD_KidData
{
    public class PD_KidDataFile
    {
        public int m_fileId;
        public int m_kidId;

        public string m_name;

        public int m_EduLevel;      //Low = 0, Medium = 1, High = 2
        public int m_DateOfBirth;   //Month + Year
        public int m_parentsEmail;


        public PD_KidDataFile(PD_KidData kids)
        {
            // set the id of this personnel file
            m_fileId = kids.m_nextFileId;

            // increment the id number
            kids.m_nextFileId++;
        }
/*
        // this gets the current skill points for the selected skill
        public int GetSkill(int skillIndex)
        {
            switch (skillIndex)
            {
                case 0: return m_low;
                case 1: return m_medium;
                case 2: return m_high;
            }

            throw new IndexOutOfRangeException();
        }

        // this sets the skill points for the selected skill
        public void SetSkill(int skillIndex, int newValue)
        {
            switch (skillIndex)
            {
                case 0: m_science = newValue; break;
                case 1: m_navigation = newValue; break;
                case 2: m_engineering = newValue; break;
                case 3: m_communications = newValue; break;
                case 4: m_medicine = newValue; break;
                default:
                    {
                        throw new IndexOutOfRangeException();
                    }
            }
        }
        */
    }

    public int m_nextFileId;
    public List<PD_KidDataFile> m_kidsList;

    // reset the kids player data
    public void Reset()
    {
        // reset the file id numbering
        m_nextFileId = 0;

        // reset the personnel list
        m_kidsList = new List<PD_KidData.PD_KidDataFile>();
    }

    // call this to create and add a new personnel to the list
    public PD_KidDataFile CreateNewKid()
    {
        return new PD_KidDataFile(this);
    }

    // this gets the personnel id from the file id
    public int GetPersonnelId(int fileId)
    {
        for (var kidId = 0; kidId < m_kidsList.Count; kidId++)
        {
            if (m_kidsList[kidId].m_fileId == fileId)
            {
                return kidId;
            }
        }

        throw new ArgumentException();
    }

    // this gets the personnel file using the file id
    public PD_KidDataFile GetPersonnelFile(int fileId)
    {
        var personnelId = GetPersonnelId(fileId);

        return m_kidsList[personnelId];
    }
}
