using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastClass
{
    private static int ok, k=1;
    public static void ending()
    {
        int[,] matrix = NewBehaviourScript.matrix;

        for (int i = 0; i < 2; i++)
        {
            ok = 0;
            for(int j = 0; j < 2; j++)
            {
                if (matrix[i,j]== matrix[i, j + 1])
                {
                    ok++;
                }
                if(ok==2 && k == 1) { k = 0; }
                ok = 0;
                for(int k2 = 0; k2 < 2; k2++)
                {
                    if (matrix[i, k2] == matrix[i + 1, k2 + 1]) { ok++; }
                    if(ok==2 && k == 1) { k = 0; }
                }
            }
        }
        if (k != 0)
        {
            if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2]) { k = 0; }
            if (matrix[2, 0] == matrix[1, 1] && matrix[1, 1] == matrix[0, 2]) { k = 0; }
        }
        if (k == 0)
        {
            GameObject.Find("Rezultat").GetComponent<TMP_Text>().text = "Winner";
        }
        else
        {
            GameObject.Find("Rezultat").GetComponent<TMP_Text>().text = "Draw";
        }
        return;
    }
}

public class NewBehaviourScript : MonoBehaviour
{
    private static int counter = 0;
    private static int  t = 0;
    public int row, collum;
    public static int[,] matrix = new int[3, 3];
    public void OnMouseDown()
    {

        char c = counter % 2 == 0 ? 'x' : 'o';
        if (matrix[row, collum] != 'o' && matrix[row,collum]!= 'x' )
        {
            GetComponent<TMP_Text>().text = c.ToString();
            ++t;
            
        }
        ++counter;
        matrix[row, collum] = c;


        if (t == 9)
        {
            LastClass.ending();
        }

       /* for (int i = 0; i < 2; i++)
        {
            ok = 0;
            for (int j = 0; j <= 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    ok++;
                }
                if (ok == 2 && k == 1)
                {
                    k = 0;
                }
                ok = 0;
                for (int k2 = 0; k2 <= 1; k2++)
                {
                    if (matrix[i, k2] == matrix[i + 1, k2 + 1])
                    {
                        ok++;
                    }
                    if (ok == 2 && k == 1)
                    {
                        k = 0;
                    }
                }
            }
        }
        if (k != 0)
        {
            if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
            {
                k = 0;
            }
            if (matrix[2, 0] == matrix[1, 1] && matrix[1, 1] == matrix[0, 2])
            {
                k = 0;
            }
        }
        if (k == 0)
        {
            GameObject.Find("Rezultat").GetComponent<TMP_Text>().text = "Winner";
        }
        else
            {
                GameObject.Find("Rezultat").GetComponent<TMP_Text>().text = "Draw";
                k = 0;
            } */
    }
}
 



