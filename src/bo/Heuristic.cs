using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CaroGame
{
    internal class Heuristic
    {
        public int[,] _evalCell;
        private int MAX_NUM_OF_HIGHEST_CELL_LIST;

        public Heuristic(int MAX_NUM_OF_HIGHEST_CELL_LIST)
        {
            _evalCell = new int[Value.SIZE, Value.SIZE];
            this.MAX_NUM_OF_HIGHEST_CELL_LIST = MAX_NUM_OF_HIGHEST_CELL_LIST;
        }

        public void resetValueCell()
        {
            for (int i = 0; i < Value.SIZE; i++)
            {
                for (int j = 0; j < Value.SIZE; j++)
                {
                    _evalCell[i,j] = 0;
                }
            }
        }
        /*
        public void evaluateEachCell(State state, int owned)
        {
            resetValueCell();
            int limit = 5;
            int[,] cell = state.getState();
            int minM, minN, maxM, maxN, m;
            float A1, A2, A3, A4;
            for (int i = 0; i < Value.SIZE; i++)
            {
                for (int j = 0; j < Value.SIZE; j++)
                {
                    // Compute "value" _evalCell[i,j] of the (i,j) move

                    if (cell[i, j] != 0) { _evalCell[i, j] = -1; continue; }
                    if (hasNeighbors(cell, i, j) == false) { _evalCell[i, j] = -1; continue; }

                    int wp = winningPos(cell, i, j, owned);
                    if (wp > 0) _evalCell[i, j] = wp;
                    else
                    {
                        float[] nPos = new float[5];
                        float[] dirA = new float[5];
                        float[] w = new float[6] { 0, 20, 17, 15, 14, 10 };

                        minM = i - (limit - 1); if (minM < 0) minM = 0; //minM: vị trí dòng tối thiểu đủ 5 con tính từ i
                        minN = j - (limit - 1); if (minN < 0) minN = 0;
                        maxM = i + limit; if (maxM > Value.SIZE) maxM = Value.SIZE;//maxM: vị trí dòng tối đa đủ 5 con tính từ i. VD: i=15, limit=5, vừa đủ ô cho 5 quân thẳng hàng 
                        maxN = j + limit; if (maxN > Value.SIZE) maxN = Value.SIZE;

                        nPos[1] = 1; A1 = 0; // Xét chiều ngang
                        m = 1; while (j + m < maxN && cell[i, j + m] != 3 - owned) { nPos[1]++; A1 += w[m] * cell[i, j + m]; m++; }
                        if (j + m >= Value.SIZE || cell[i, j + m] == 3 - owned) A1 -= (cell[i, j + m - 1] == owned) ? (w[limit] * owned) : 0;
                        m = 1; while (j - m >= minN && cell[i, j - m] != 3 - owned) { nPos[1]++; A1 += w[m] * cell[i, j - m]; m++; }
                        if (j - m < 0 || cell[i, j - m] == 3 - owned) A1 -= (cell[i, j - m + 1] == owned) ? (w[limit] * owned) : 0;


                        nPos[2] = 1; A2 = 0;
                        m = 1; while (i + m < maxM && cell[i + m, j] != 3 - owned) { nPos[2]++; A2 += w[m] * cell[i + m, j]; m++; }
                        if (i + m >= Value.SIZE || cell[i + m, j] == 3 - owned) A2 -= (cell[i + m - 1, j] == owned) ? (w[limit] * owned) : 0;
                        m = 1; while (i - m >= minM && cell[i - m, j] != 3 - owned) { nPos[2]++; A2 += w[m] * cell[i - m, j]; m++; }
                        if (i - m < 0 || cell[i - m, j] == 3 - owned) A2 -= (cell[i - m + 1, j] == owned) ? (w[limit] * owned) : 0;


                        nPos[3] = 1; A3 = 0;
                        m = 1; while (i + m < maxM && j + m < maxN && cell[i + m, j + m] != 3 - owned) { nPos[3]++; A3 += w[m] * cell[i + m, j + m]; m++; }
                        if (i + m >= Value.SIZE || j + m >= Value.SIZE || cell[i + m, j + m] == 3 - owned) A3 -= (cell[i + m - 1, j + m - 1] == owned) ? (w[limit] * owned) : 0;
                        m = 1; while (i - m >= minM && j - m >= minN && cell[i - m, j - m] != 3 - owned) { nPos[3]++; A3 += w[m] * cell[i - m, j - m]; m++; }
                        if (i - m < 0 || j - m < 0 || cell[i - m, j - m] == 3 - owned) A3 -= (cell[i - m + 1, j - m + 1] == owned) ? (w[limit] * owned) : 0;


                        nPos[4] = 1; A4 = 0;
                        m = 1; while (i + m < maxM && j - m >= minN && cell[i + m, j - m] != 3 - owned) { nPos[4]++; A4 += w[m] * cell[i + m, j - m]; m++; }
                        if (i + m >= Value.SIZE || j - m < 0 || cell[i + m, j - m] == 3 - owned) A4 -= (cell[i + m - 1, j - m + 1] == owned) ? (w[limit] * owned) : 0;
                        m = 1; while (i - m >= minM && j + m < maxN && cell[i - m, j + m] != 3 - owned) { nPos[4]++; A4 += w[m] * cell[i - m, j + m]; m++; }
                        if (i - m < 0 || j + m >= Value.SIZE || cell[i - m, j + m] == 3 - owned) A4 -= (cell[i - m + 1, j + m - 1] == owned) ? (w[limit] * owned) : 0;


                        dirA[1] = (nPos[1] > (limit - 1)) ? A1 * A1 : 0;
                        dirA[2] = (nPos[2] > (limit - 1)) ? A2 * A2 : 0;
                        dirA[3] = (nPos[3] > (limit - 1)) ? A3 * A3 : 0;
                        dirA[4] = (nPos[4] > (limit - 1)) ? A4 * A4 : 0;

                        A1 = 0; A2 = 0;
                        for (int k = 1; k < limit; k++)
                        {
                            if (dirA[k] >= A1) { A2 = A1; A1 = dirA[k]; }
                        }
                        _evalCell[i, j] = A1 + A2;
                    }
                }
            }
        }
        */


        int[] defenseScore = { 0, 1, 9, 81, 729, 6534 }; // bảng điểm phòng thủ
        int[] attackScore = { 0, 3, 24, 192, 1536, 12288 }; // bảng điểm tấn công
        public void evaluateEachCell(State state, int player)
        {
            resetValueCell();
            int x, y, i, countAI, countUser;
            int[,] cell = state.getState();
            /*Kiểm tra theo hàng 
             * -----
             * -----
             * -----
             * */
            for (x = 0; x < Value.SIZE; x++)
            {
                for (y = 0; y < Value.SIZE - 4; y++)
                {
                    countAI = 0; countUser = 0;
                    /*đếm số ô người chơi và AI đã đánh ở đoạn từ y đến y+4*/
                    for (i = 0; i < 5; i++)
                    { // duyệt đoạn
                        if (cell[x,y + i] == Value.BLACK_MOVE) countAI++;
                        else if (cell[x,y + i] == Value.WHITE_MOVE) countUser++;
                    }
                    /*Nếu ở đoạn này một trong hai không đánh ô nào và người còn lại có đánh ít nhất 1 ô*/
                    if (countAI * countUser == 0 && countAI != countUser)
                    {
                        for (i = 0; i < 5; i++)
                        { // duyệt đoạn
                            if (cell[x,y + i] == 0)
                            { // nếu ô này ko ai đánh
                                if (countAI == 0)
                                { // nếu ở đoạn này AI không đánh ô nào cả
                                    if (player == Value.BLACK_MOVE)
                                    { // nếu lượt chơi hiện tại là của AI
                                        _evalCell[x,y + i] += defenseScore[countUser]; // thì cộng điểm phòng ngự ở ô này
                                    }
                                    else _evalCell[x,y + i] += attackScore[countUser]; // ngược lại, thì tăng điểm tấn công ở ô này
                                }
                                else if (countUser == 0)
                                { // nếu ở đoạn này User không đánh ô nào cả
                                    if (player == Value.WHITE_MOVE)
                                    { // nếu lượt chơi hiện tại là của User
                                        _evalCell[x,y + i] += defenseScore[countAI]; // thì cộng điểm phòng ngự ở ô này
                                    }
                                    else _evalCell[x,y + i] += attackScore[countAI]; //ngược lại,cộng điểm tấn công của ô này
                                }
                                if (countAI == 4 || countUser == 4)
                                { // Nếu một trong hai người chơi có nước 4
                                    _evalCell[x,y + i] *= 2; // thì lượng giá ô này lên gấp đôi
                                }
                            }
                        }
                    }
                }
            }
            /*Kiểm tra theo cột 
             * |||||||
             * |||||||
             * |||||||
             * */
            for (x = 0; x < Value.SIZE - 4; x++)
            {
                for (y = 0; y < Value.SIZE; y++)
                {
                    countAI = 0; countUser = 0;
                    for (i = 0; i < 5; i++)
                    {
                        if (cell[x + i,y] == Value.BLACK_MOVE) countAI++;
                        else if (cell[x + i,y] == Value.WHITE_MOVE) countUser++;
                    }
                    if (countAI * countUser == 0 && countAI != countUser)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            if (cell[x + i,y] == 0)
                            {
                                if (countAI == 0)
                                {
                                    if (player == Value.BLACK_MOVE)
                                    {
                                        _evalCell[x + i,y] += defenseScore[countUser];
                                    }
                                    else _evalCell[x + i,y] += attackScore[countUser];
                                }
                                else if (countUser == 0)
                                {
                                    if (player == Value.WHITE_MOVE)
                                    {
                                        _evalCell[x + i,y] += defenseScore[countAI];
                                    }
                                    else _evalCell[x + i,y] += attackScore[countAI];
                                }
                                if (countAI == 4 || countUser == 4)
                                {
                                    _evalCell[x + i,y] *= 2;
                                }
                            }
                        }
                    }
                }
            }

            /*Kiểm tra theo đường chéo chính 
             * \\\\\\
             * \\\\\\
             * \\\\\\
             * */
            for (x = 0; x < Value.SIZE - 4; x++)
            {
                for (y = 0; y < Value.SIZE - 4; y++)
                {
                    countAI = 0; countUser = 0;
                    for (i = 0; i < 5; i++)
                    {
                        if (cell[x + i,y + i] == Value.BLACK_MOVE) countAI++;
                        else if (cell[x + i,y + i] == Value.WHITE_MOVE) countUser++;
                    }
                    if (countAI * countUser == 0 && countAI != countUser)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            if (cell[x + i,y + i] == 0)
                            {
                                if (countAI == 0)
                                {
                                    if (player == Value.BLACK_MOVE)
                                    {
                                        _evalCell[x + i,y + i] += defenseScore[countUser];
                                    }
                                    else _evalCell[x + i,y + i] += attackScore[countUser];
                                }
                                else if (countUser == 0)
                                {
                                    if (player == Value.WHITE_MOVE)
                                    {
                                        _evalCell[x + i,y + i] += defenseScore[countAI];
                                    }
                                    else _evalCell[x + i,y + i] += attackScore[countAI];
                                }
                                if (countAI == 4 || countUser == 4)
                                {
                                    _evalCell[x + i,y + i] *= 2;
                                }
                            }
                        }
                    }
                }
            }

            /*Kiểm tra theo đường chéo phụ*/

            for (x = 4; x < Value.SIZE; x++)
            {
                for (y = 0; y < Value.SIZE - 4; y++)
                {
                    countAI = 0; countUser = 0;
                    for (i = 0; i < 5; i++)
                    {
                        if (cell[x - i,y + i] == Value.BLACK_MOVE) countAI++;
                        else if (cell[x - i,y + i] == Value.WHITE_MOVE) countUser++;
                    }
                    if (countAI * countUser == 0 && countAI != countUser)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            if (cell[x - i,y + i] == 0)
                            {
                                if (countAI == 0)
                                {
                                    if (player == Value.BLACK_MOVE)
                                    {
                                        _evalCell[x - i,y + i] += defenseScore[countUser];
                                    }
                                    else _evalCell[x - i,y + i] += attackScore[countUser];
                                }
                                else if (countUser == 0)
                                {
                                    if (player == Value.WHITE_MOVE)
                                    {
                                        _evalCell[x - i,y + i] += defenseScore[countAI];
                                    }
                                    else _evalCell[x - i,y + i] += attackScore[countAI];
                                }
                                if (countAI == 4 || countUser == 4)
                                {
                                    _evalCell[x - i,y + i] *= 2;
                                }
                            }
                        }
                    }
                }
            }
        }

        private int[] point = {
        4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
        8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
        8, 8, 8, 8, 8, 8,
        8, 8, 8, 8, 8, 8,
        8, 8, 8, 8, 8, 8,
        8, 8, 8, 8, 8, 8,
        8, 8, 8, 8,
        500, 500, 500, 500, 500, 500, 500,
        1000, 1000, 1000, 1000, 1000, 1000, 
        1000, 1000, 1000, 1000, 1000, 1000,
        1000, 1000, 1000, 1000, 1000, 1000,
        1000, 1000, 1000, 1000, 1000, 1000,
        100000, 100000, 100000, 100000
        };
        private String[] caseAI = {
            "011001", "010101", "010011", "110010", "101010", "100110", ";11001", ";10101", ";10011", "11001;", "10101;", "10011;",
            "000110", "001010", "001100", "001100", "010100", "011000", ";00110", ";01010", ";01100", "00110;", "01010;", "01100;",
            "011100", "011010", "010110", "001101", "001011", "000111",
            "111000", "110100", "101100", "011010", "010110", "001110",
            ";11100", ";11010", ";10110", ";01101", ";01011", ";00111",
            "11100;", "11010;", "10110;", "01101;", "01011;", "00111;",
            ";01110","01110;", "001110","011100",
            "011100", "011010", "010110", "001110", "1010101", "1011001", "1001101", 
    	    "011110","101110", "110110", "111010", "111010",  "111100",
            "001111","010111", "011011", "011101", "011101",  "011110",
            ";01111",";10111", ";11011", ";11101", ";11101",  ";11110",
            "01111;","10111;", "11011;", "11101;", "11101;",  "11110;",
            "011111", "111110", ";11111", "11111;"
        };
        private String[] caseUser = {
            "022002", "020202", "020022", "220020", "202020", "200220", ";22002", ";20202", ";20022", "22002;", "20202;", "20022;",
            "000220", "002020", "002200", "002200", "020200", "022000", ";00220", ";02020", ";02200", "00220;", "02020;", "02200;",
            "022200", "022020", "020220", "002202", "002022", "000222",
            "222000", "220200", "202200", "022020", "020220", "002220",
            ";22200", ";22020", ";20220", ";02202", ";02022", ";00222",
            "22200;", "22020;", "20220;", "02202;", "02022;", "00222;",
            ";02220","02220;", "002220","022200",
            "022200", "022020", "020220", "002220", "2020202", "2022002", "2002202", 
    	    "022220","202220", "220220", "222020", "222020",  "222200",
            "002222","020222", "022022", "022202", "022202",  "022220",
            ";02222",";20222", ";22022", ";22202", ";22202",  ";22220",
            "02222;","20222;", "22022;", "22202;", "22202;",  "22220;",
            "022222", "222220", ";22222", "22222;"
        };

        public long evaluateState(State state)
        {
            String rem = ";";
            int[,] cell = state.getState();
            //check hàng và cột (|,__)
            for (int i = 0; i < Value.SIZE; i++)
            {
                for (int j = 0; j < Value.SIZE; j++)
                {
                    rem += cell[i,j];
                }
                rem += ";";
                for (int j = 0; j < Value.SIZE; j++)
                {
                    rem += cell[j,i];
                }
                rem += ";";
            }
            // check nửa trên đường chéo phải ( \ )
            for (int i = 0; i < Value.SIZE - 4; i++)
            {
                for (int j = 0; j < Value.SIZE - i; j++)
                {
                    rem += cell[j,i + j];
                }
                rem += ";";
            }
            // check nửa dưới đường chéo phải ( \ )
            for (int i = Value.SIZE - 5; i > 0; i--)
            {
                for (int j = 0; j < Value.SIZE - i; j++)
                {
                    rem += cell[i + j,j];
                }
                rem += ";";
            }
            // check nửa trên đường chéo trái ( / )
            for (int i = 4; i < Value.SIZE; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    rem += cell[i - j,j];
                }
                rem += ";";
            }
            // check nửa dưới đường chéo trái ( / )
            for (int i = Value.SIZE - 5; i > 0; i--)
            {
                for (int j = Value.SIZE - 1; j >= i; j--)
                {
                    rem += cell[j,i + Value.SIZE - j - 1];
                }
                rem += ";\n";
            }
            //Console.WriteLine("\nREM: " + rem);
            String find1, find2;
            long diem = 0;
            // Tính điểm của trạng thái
            for (int i = 0; i < caseUser.Length; i++)
            { // duyệt các đường chiến lược
                find1 = caseAI[i]; // duyệt những đường chiến lược của AI
                find2 = caseUser[i]; // duyệt những đường chiến lược của  User
                diem += point[i] * match(rem, find1); // cộng vào điểm lượng giá của AI
                diem -= point[i] * match(rem, find2); // trừ đi điểm lượng giá của User           
            }
            return diem;
        }

        public int match(String text, String find)
        {
            Regex regex= new Regex(find);
            return (regex.IsMatch(text) ? 1 : 0);
        }

        public List<EvalCell> getOptimalCellList()
        {
            int size = MAX_NUM_OF_HIGHEST_CELL_LIST; // số phần tử tối đa được phép lấy
            int[] maxValueList = new int[size];
            Cell[] maxCellList = new Cell[size];
            // khởi tạo giá trị
            for (int i = 0; i < size; i++)
            {
                maxValueList[i] = Int16.MinValue;
                maxCellList[i] = new Cell();
            }
            for (int x = 0; x < Value.SIZE; x++)
            {
                for (int y = 0; y < Value.SIZE; y++)
                {
                    int value = _evalCell[x,y];
                    /*Tìm list những ô tối ưu để đánh*/
                    for (int i = size - 1; i >= 0; i--)
                    {
                        if (maxValueList[i] <= value && value != 0)
                        {
                            /* sắp xếp theo thứ tự tăng dần */
                            for (int j = 0; j < i; j++)
                            { // cập nhật những phần tử trước i
                                maxValueList[j] = maxValueList[j + 1]; // cập nhật điểm
                                maxCellList[j].setLocation(maxCellList[j + 1].row, maxCellList[j + 1].col); // cập nhật vị trí
                            }
                            // cập nhật phần tử i
                            maxValueList[i] = value;
                            maxCellList[i].setLocation(x, y);
                            break;
                        }
                    }
                }
            }
            //Console.WriteLine();
            //for(int i=0; i<size; i++)
            //    Console.Write(maxValueList[i]+", ");
            //Console.WriteLine();
            // add vào list những phần tử có số điểm lớn nhất có độ lớn gần bằng nhau(ex: 981, 857, 80, 15 => chỉ chọn 981 và 857)
            int maxLength = lengthNum(maxValueList[size - 1]); // length của số lớn nhất
            int[] difference = { 0, 2, 8, 32, 128, 512 }; // chênh lệch theo từng cấp độ dài so với phần tử lớn nhất
            List<EvalCell> list = new List<EvalCell>(); // danh sách điểm được sắp xếp giảm dần
            list.Add(new EvalCell(maxCellList[size - 1], maxValueList[size - 1])); // add vào phần tử có điểm lớn nhất
            
            //Console.WriteLine();
            for (int i = size - 2; i >= 0; i--)
            { // add vào các phần tử còn lại phù hợp điều kiện
                if (maxValueList[size - 1] - maxValueList[i] <= difference[maxLength] || MAX_NUM_OF_HIGHEST_CELL_LIST == Value.MAX_NUM_OF_HIGHEST_CELL_LIST_EASY)
                { // chỉ chấp nhận chênh lệch so với pt lớn nhất trong khoảng quy định
                    list.Add(new EvalCell(maxCellList[i], maxValueList[i]));
                }
                else break;
            }
            //Console.Write("list: ");
            //list.ForEach(cell =>
            //{
            //    Console.Write(cell.getValue() + ", ");
            //});
            //Console.WriteLine();
            return list;
        }

        private int lengthNum(int a)
        {
            if (a == 0) return 1;
            if (a < 0) a *= -1;
            int dem = 0;
            while (a > 0)
            {
                a /= 10;
                dem++;
            }
            return dem;
        }

        public void printEvalEachCell(int dept)
        {
            Console.WriteLine("EvalCell[dept: "+dept+"]:");
            for (int i = 0; i < Value.SIZE; i++)
            {
                for (int j = 0; j < Value.SIZE; j++)
                {
                    int len = lengthNum((int)_evalCell[i,j]);
                    String rem = ((int)_evalCell[i,j]).ToString();
                    if (len == 1) Console.Write(rem + "    ");

                else if (len == 2) Console.Write(rem + "   ");

                else if (len == 3) Console.Write(rem + "  ");

                else Console.Write(rem + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
