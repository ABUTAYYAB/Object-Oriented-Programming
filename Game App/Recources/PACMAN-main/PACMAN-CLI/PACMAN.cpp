#include <iostream>
#include <windows.h>

using namespace std;

void maze();
void gotoxy(int x, int y);
void print_pacman(int, int);
void erase_pacman(int, int);
void destroy_pacman(int, int);
void print_ghost(int, int);
void erase_ghost(int, int);
char getCharAtxy(short int x, short int y);
void gameOver();
void ghostPositions();
void moveLeft();
void moveRight();
void moveUp();
void moveDown();

bool game_running = true;
int score = 0;
int pacman_x = 1;
int pacman_y = 1;
int ghost_1x = 25;
int ghost_1y = 1;
int ghost_2x = 2;
int ghost_2y = 8;
int ghost_3x = 2;
int ghost_3y = 2;

main()
{
    system("cls");
    maze();
    gotoxy(pacman_x, pacman_y);
    cout << "P";
    if (game_running == false)
    {
        gameOver();
        cout << "Your score was " << score;
    }
    while (game_running)
    {
        ghostPositions();
        if (GetAsyncKeyState(VK_LEFT))
        {
            moveLeft();
        }
        else if (GetAsyncKeyState(VK_RIGHT))
        {
            moveRight();
        }
        else if (GetAsyncKeyState(VK_UP))
        {
            moveUp();
        }
        else if (GetAsyncKeyState(VK_DOWN))
        {
            moveDown();
        }
        gotoxy(18, 18);
        cout << "Current Score : " << score;
        if (score == 317)
        {
            game_running = false;
        }
        Sleep(100);
    }
    if (game_running == false)
    {
        gameOver();
        gotoxy(18, 18);
        cout << "Your score was : " << score;
        gotoxy(0, 20);
    }
}
void maze()
{
    const int rows = 17;
    const int cols = 53;
    char maze[rows][cols] = {
        {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', '.', '.', '.', '.', 'H', '.', '.', '.', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', '.', '.', '.', '.', '.', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', '.', '.', 'H', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', '.', '.', '.', '.', '.', 'H', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', '.', '.', '.', '.', '.', ' ', '#'},
        {'#', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', 'H', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'H', '.', '.', '.', '.', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', ' ', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}};
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            cout << maze[i][j];
        }
        cout << endl;
    }
}
void gotoxy(int x, int y)
{
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}
void print_pacman(int pacman_x, int pacman_y)
{
    gotoxy(pacman_x, pacman_y);
    cout << "P";
}
void erase_pacman(int pacman_x, int pacman_y)

{
    gotoxy(pacman_x, pacman_y);
    cout << " ";
}
void destroy_pacman(int pacman_x, int pacman_y)
{
    gotoxy(pacman_x, pacman_y);
    cout << "P";
    Sleep(100);
    gotoxy(pacman_x, pacman_y);
    cout << "l";
    Sleep(100);
    gotoxy(pacman_x, pacman_y);
    cout << "k";
    Sleep(100);
    gotoxy(pacman_x, pacman_y);
    cout << "v";
    Sleep(100);
    gotoxy(pacman_x, pacman_y);
    cout << " ";
    Sleep(100);
    game_running = false;
}
void print_ghost(int ghostx, int ghosty)
{
    gotoxy(ghostx, ghosty);
    cout << "G";
}
void erase_ghost(int ghostx, int ghosty)
{
    gotoxy(ghostx, ghosty);
    cout << " ";
}
char getCharAtxy(short int x, short int y)
{
    CHAR_INFO ci;
    COORD xy = {0, 0};
    SMALL_RECT react = {x, y, x, y};
    COORD coordBufSize;
    coordBufSize.X = 1;
    coordBufSize.Y = 1;
    return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), &ci, coordBufSize, xy, &react) ? ci.Char.AsciiChar : ' ';
}
void gameOver()
{
    system("cls");
    cout << "############################################################################" << endl;
    cout << "#                                                                          #" << endl;
    cout << "#         GGGGGGGGG        AAAAA        MMM           MMM    EEEEEEEEEE    #" << endl;
    cout << "#       GG                AA   AA       MM M         M MM    EE            #" << endl;
    cout << "#     GG                 AA     AA      MM   M     M   MM    EE            #" << endl;
    cout << "#    GG                 AA       AA     MM     M M     MM    EEEEEEE       #" << endl;
    cout << "#    GG     GGGGGGGGG   AA AAAAA AA     MM             MM    EE            #" << endl;
    cout << "#     GG          GG    AA       AA     MM             MM    EE            #" << endl;
    cout << "#       GGGGGGGGG       AA       AA     MM             MM    EEEEEEEEEE    #" << endl;
    cout << "#                                                                          #" << endl;
    cout << "#          OOOOOOOO        VV           VV    EEEEEEEEE    RRRRRRRR        #" << endl;
    cout << "#        OO        OO       VV         VV     EE           RR     RR       #" << endl;
    cout << "#       OO          OO       VV       VV      EE           RR    RR        #" << endl;
    cout << "#      OO            OO       VV     VV       EEEEEEE      RR   RR         #" << endl;
    cout << "#       OO          OO         VV   VV        EE           RR  RR          #" << endl;
    cout << "#         OO      OO            VV VV         EE           RR    RR        #" << endl;
    cout << "#           OOOOOOO              VVV          EEEEEEEEE    RR      RR      #" << endl;
    cout << "#                                                                          #" << endl;
    cout << "############################################################################" << endl;
}
void ghostPositions()
{
    char ghost1_nextLocation = getCharAtxy(ghost_1x, ghost_1y + 1);
    if (ghost1_nextLocation == ' ')
    {
        erase_ghost(ghost_1x, ghost_1y);
        ghost_1y = ghost_1y + 1;
        print_ghost(ghost_1x, ghost_1y);
    }
    else if (ghost1_nextLocation == '.')
    {
        erase_ghost(ghost_1x, ghost_1y);
        ghost_1y = ghost_1y + 1;
        print_ghost(ghost_1x, ghost_1y);
    }
    else if (ghost1_nextLocation == '#')
    {
        erase_ghost(ghost_1x, ghost_1y);
        ghost_1y = 1;
        print_ghost(ghost_1x, ghost_1y);
    }
    else if (ghost1_nextLocation == 'P')
    {
        destroy_pacman(pacman_x, pacman_y);
    }
    char ghost2_nextLocation = getCharAtxy(ghost_2x + 1, ghost_2y);
    if (ghost2_nextLocation == ' ')
    {
        erase_ghost(ghost_2x, ghost_2y);
        ghost_2x = ghost_2x + 1;
        print_ghost(ghost_2x, ghost_2y);
    }
    else if (ghost2_nextLocation == '.')
    {
        erase_ghost(ghost_2x, ghost_2y);
        ghost_2x = ghost_2x + 1;
        print_ghost(ghost_2x, ghost_2y);
    }
    else if (ghost2_nextLocation == '#')
    {
        erase_ghost(ghost_2x, ghost_2y);
        ghost_2x = 2;
        print_ghost(ghost_2x, ghost_2y);
    }
    else if (ghost2_nextLocation == 'P')
    {
        destroy_pacman(pacman_x, pacman_y);
    }
    char ghost3_nextLocation = getCharAtxy(ghost_3x + 1, ghost_3y);
    if (ghost3_nextLocation == ' ')
    {
        erase_ghost(ghost_3x, ghost_3y);
        ghost_3x = ghost_3x + 1;
        print_ghost(ghost_3x, ghost_3y);
    }
    else if (ghost3_nextLocation == '.')
    {
        erase_ghost(ghost_3x, ghost_3y);
        ghost_3x = ghost_3x + 1;
        print_ghost(ghost_3x, ghost_3y);
    }
    else if (ghost3_nextLocation == '#')
    {
        erase_ghost(ghost_3x, ghost_3y);
        ghost_3x = 2;
        print_ghost(ghost_3x, ghost_3y);
    }
    else if (ghost3_nextLocation == 'P')
    {
        destroy_pacman(pacman_x, pacman_y);
    }
}
void moveLeft()
{
    char nextLocation = getCharAtxy(pacman_x - 1, pacman_y);
    if (nextLocation == ' ')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_x = pacman_x - 1;
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '#')
    {
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '.')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_x = pacman_x - 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 1;
    }
    else if (nextLocation == 'H')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_x = pacman_x - 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 5;
    }
}
void moveRight()
{
    char nextLocation = getCharAtxy(pacman_x + 1, pacman_y);
    if (nextLocation == ' ')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_x = pacman_x + 1;
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '#')
    {
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '.')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_x = pacman_x + 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 1;
    }
    else if (nextLocation == 'H')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_x = pacman_x + 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 5;
    }
}
void moveUp()
{
    char nextLocation = getCharAtxy(pacman_x, pacman_y - 1);
    if (nextLocation == ' ')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_y = pacman_y - 1;
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '#')
    {
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '.')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_y = pacman_y - 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 1;
    }
    else if (nextLocation == 'H')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_y = pacman_y - 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 5;
    }
}
void moveDown()
{

    char nextLocation = getCharAtxy(pacman_x, pacman_y + 1);
    if (nextLocation == ' ')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_y = pacman_y + 1;
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '#')
    {
        print_pacman(pacman_x, pacman_y);
    }
    else if (nextLocation == '.')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_y = pacman_y + 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 1;
    }
    else if (nextLocation == 'H')
    {
        erase_pacman(pacman_x, pacman_y);
        pacman_y = pacman_y + 1;
        print_pacman(pacman_x, pacman_y);
        score = score + 5;
    }
}
