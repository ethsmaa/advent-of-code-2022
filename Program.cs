using System;

string[] file = File.ReadAllLines("day2.txt");
int won = 0;
int shape = 0;
int finalTotal = 0;

for (int i = 0; i < file.Length; i++)
{
    char yourshape = file[i][2];
    char elveshape = file[i][0];
    switch (elveshape)
    {
        case 'A': // tas
            switch (yourshape)
            {
                case 'X':
                    won += 3;
                    shape += 1;
                    break;

                case 'Y':
                    won += 6;
                    shape += 2;
                    break;

                case 'Z':

                    shape += 3;
                    break;
            }
            break;
        case 'B': //  kagıt
            switch (yourshape)
            {
                case 'X':
                    shape += 1;
                    break;
                case 'Y':
                    won += 3;
                    shape += 2;
                    break;

                case 'Z':
                    won += 6;
                    shape += 3;
                    break;
            }
            break;
        case 'C': // makas
            switch (yourshape)
            {

                case 'X':
                    won += 6;
                    shape += 1;
                    break;

                case 'Y':
                    shape += 2;
                    break;

                case 'Z':
                    won += 3;
                    shape += 3;
                    break;
            }

            break;
    }
    finalTotal = won + shape;

}

Console.WriteLine(finalTotal);

won = 0;
shape = 0;


for (int i = 0; i < file.Length; i++)
{

    char yourshape = file[i][2];
    char elveshape = file[i][0];

    switch (elveshape)
    {

        case 'A':// tas

            switch (yourshape)
            {

                case 'X': //lose // c // tasa karsı kaybet
                    won += 0;
                    shape += 3;
                    break;
                case 'Y': //tie /a
                    won += 3;
                    shape += 1;
                    break;
                case 'Z': //win /b
                    won += 6;
                    shape += 2;
                    break;
            }
            break;
        case 'B': // kagıt
            switch (yourshape)
            {
                case 'X': //lose // a
                    won += 0;
                    shape += 1;
                    break;
                case 'Y': //tie /b
                    won += 3;
                    shape += 2;
                    break;
                case 'Z': //win /c
                    won += 6;
                    shape += 3;
                    break;
            }
            break;
        case 'C':
            switch (yourshape)
            {
                case 'X': //lose // b
                    won += 0;
                    shape += 2;
                    break;
                case 'Y': //tie /c
                    won += 3;
                    shape += 3;
                    break;
                case 'Z': //win /a
                    won += 6;
                    shape += 1;
                    break;
            }
            break;
    }
    finalTotal = won + shape;
}
Console.WriteLine(finalTotal);