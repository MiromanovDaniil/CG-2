using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace CG_2
{
    public partial class Form1 : Form
    {
        //Матрица преобразования 
        Matrix TransformMatrix = new Matrix(3, 3);
        //Вершины фигуры;
        Matrix point_1 = new Matrix(3, 1);
        Matrix point_2 = new Matrix(3, 1);
        Matrix point_3 = new Matrix(3, 1);
        Matrix point_4 = new Matrix(3, 1);
        Matrix point_5 = new Matrix(3, 1);
        Matrix point_6 = new Matrix(3, 1);
        Matrix point_7 = new Matrix(3, 1);

        //Вершины Человечка;
        Matrix pointh_1 = new Matrix(3, 1);
        Matrix pointh_2 = new Matrix(3, 1);
        Matrix pointh_3 = new Matrix(3, 1);
        Matrix pointh_4 = new Matrix(3, 1);
        Matrix pointh_5 = new Matrix(3, 1);
        Matrix pointh_6 = new Matrix(3, 1);
        Matrix pointh_7 = new Matrix(3, 1);
        Matrix pointh_8 = new Matrix(3, 1);
        Matrix pointh_9 = new Matrix(3, 1);
        Matrix pointh_10 = new Matrix(3, 1);
        Matrix pointh_11 = new Matrix(3, 1);
        Matrix pointh_12 = new Matrix(3, 1);
        Matrix pointh_13 = new Matrix(3, 1);
        Matrix pointh_14 = new Matrix(3, 1);
        Matrix pointh_15 = new Matrix(3, 1);
        Matrix pointh_16 = new Matrix(3, 1);
        Matrix pointh_17 = new Matrix(3, 1);
      
        public Form1()
        {
            InitializeComponent();
            set_visible_coordinates();
            set_settings();
            set_start_position();
            set_start_Human_position();
            set_start_Transform_Matrix();
            DrawFigure();
        }
        string zedGraph_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            // Получим точку, около которой находимся
            PointPair point = curve[iPt];

            // Сформируем строку
            string result = string.Format("X: {0:F3}\nY: {1:F3}", point.X, point.Y);

            return result;
        }
        private void set_visible_coordinates()
        {
            // Включим показ всплывающих подсказок при наведении курсора на график
            zedGraph.IsShowPointValues = true;

            // Будем обрабатывать событие PointValueEvent, чтобы изменить формат представления координат
            zedGraph.PointValueEvent += new ZedGraphControl.PointValueHandler(zedGraph_PointValueEvent);
        }
        private void set_settings()
        {
            GraphPane pane = zedGraph.GraphPane;

            // Ось X будет пересекаться с осью Y на уровне Y = 0
            pane.XAxis.Cross = 0.0;

            // Ось Y будет пересекаться с осью X на уровне X = 0
            pane.YAxis.Cross = 0.0;

            // Отключим отображение первых и последних меток по осям
            pane.XAxis.Scale.IsSkipFirstLabel = true;
            pane.XAxis.Scale.IsSkipLastLabel = true;

            // Отключим отображение меток в точке пересечения с другой осью
            pane.XAxis.Scale.IsSkipCrossLabel = true;


            // Отключим отображение первых и последних меток по осям
            pane.YAxis.Scale.IsSkipFirstLabel = true;

            // Отключим отображение меток в точке пересечения с другой осью
            pane.YAxis.Scale.IsSkipLastLabel = true;
            pane.YAxis.Scale.IsSkipCrossLabel = true;

            // Спрячем заголовки осей
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;

            pane.Title.Text = "Computer Graphics №2";

            // Добавляю линии сетки на график и делаю их серыми
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.Color = Color.Gray;
            pane.YAxis.MajorGrid.Color = Color.Gray;

            double xmin_limit = -15;
            double xmax_limit = 15;

            double ymin_limit = -15;
            double ymax_limit = 15;

            // Устанавливаем интервал по оси X
            pane.XAxis.Scale.Min = xmin_limit;
            pane.XAxis.Scale.Max = xmax_limit;

            // !!!
            // Устанавливаем интервал по оси Y
            pane.YAxis.Scale.Min = ymin_limit;
            pane.YAxis.Scale.Max = ymax_limit;
        }
        private void start_scale_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;

            // Установим масштаб по умолчанию для оси X
            pane.XAxis.Scale.Min = -15;
            pane.XAxis.Scale.Max = 15;

            // Установим масштаб по умолчанию для оси Y
            pane.YAxis.Scale.Min = -15;
            pane.YAxis.Scale.Max = 15;

            // Обновим данные об осях
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
        private void DrawFigure()
        {
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list12 = new PointPairList();
            PointPairList list23 = new PointPairList();
            PointPairList list34 = new PointPairList();
            PointPairList list45 = new PointPairList();
            PointPairList list56 = new PointPairList();
            PointPairList list67 = new PointPairList();
            PointPairList list71 = new PointPairList();
            PointPairList list27 = new PointPairList();
            PointPairList list37 = new PointPairList();
            PointPairList list47 = new PointPairList();
            PointPairList list46 = new PointPairList();

            //Добавление точек
            list12.Add(point_1[0, 0], point_1[1, 0]);
            list12.Add(point_2[0, 0], point_2[1, 0]);

            list23.Add(point_2[0, 0], point_2[1, 0]);
            list23.Add(point_3[0, 0], point_3[1, 0]);

            list34.Add(point_3[0, 0], point_3[1, 0]);
            list34.Add(point_4[0, 0], point_4[1, 0]);

            list45.Add(point_4[0, 0], point_4[1, 0]);
            list45.Add(point_5[0, 0], point_5[1, 0]);

            list56.Add(point_5[0, 0], point_5[1, 0]);
            list56.Add(point_6[0, 0], point_6[1, 0]);

            list67.Add(point_6[0, 0], point_6[1, 0]);
            list67.Add(point_7[0, 0], point_7[1, 0]);

            list71.Add(point_7[0, 0], point_7[1, 0]);
            list71.Add(point_1[0, 0], point_1[1, 0]);

            list27.Add(point_2[0, 0], point_2[1, 0]);
            list27.Add(point_7[0, 0], point_7[1, 0]);

            list37.Add(point_3[0, 0], point_3[1, 0]);
            list37.Add(point_7[0, 0], point_7[1, 0]);

            list47.Add(point_4[0, 0], point_4[1, 0]);
            list47.Add(point_7[0, 0], point_7[1, 0]);

            list46.Add(point_4[0, 0], point_4[1, 0]);
            list46.Add(point_6[0, 0], point_6[1, 0]);

            // Создадим кривые
            LineItem curve12 = pane.AddCurve("", list12, Color.Blue, SymbolType.None);
            LineItem curve23 = pane.AddCurve("", list23, Color.Blue, SymbolType.None);
            LineItem curve34 = pane.AddCurve("", list34, Color.Blue, SymbolType.None);
            LineItem curve45 = pane.AddCurve("", list45, Color.Blue, SymbolType.None);
            LineItem curve56 = pane.AddCurve("", list56, Color.Blue, SymbolType.None);
            LineItem curve67 = pane.AddCurve("", list67, Color.Blue, SymbolType.None);
            LineItem curve71 = pane.AddCurve("", list71, Color.Blue, SymbolType.None);
            LineItem curve27 = pane.AddCurve("", list27, Color.Blue, SymbolType.None);
            LineItem curve37 = pane.AddCurve("", list37, Color.Blue, SymbolType.None);
            LineItem curve47 = pane.AddCurve("", list47, Color.Blue, SymbolType.None);
            LineItem curve46 = pane.AddCurve("", list46, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
        //Начальное положение для отрисовки фигуры
        private void set_start_position()
        {
            point_1[0, 0] = 1;
            point_1[1, 0] = 1;
            point_1[2, 0] = 1;

            point_2[0, 0] = 7;
            point_2[1, 0] = 1;
            point_2[2, 0] = 1;

            point_3[0, 0] = 7;
            point_3[1, 0] = 3;
            point_3[2, 0] = 1;

            point_4[0, 0] = 7;
            point_4[1, 0] = 5;
            point_4[2, 0] = 1;

            point_5[0, 0] = 4;
            point_5[1, 0] = 8;
            point_5[2, 0] = 1;

            point_6[0, 0] = 1;
            point_6[1, 0] = 5;
            point_6[2, 0] = 1;

            point_7[0, 0] = 1;
            point_7[1, 0] = 3;
            point_7[2, 0] = 1;
        }
        //Начальное положение для отрисовки Человечка
        private void set_start_Human_position()
        {
            //Ноги
            pointh_1[0, 0] = 3.9;
            pointh_1[1, 0] = 0;
            pointh_1[2, 0] = 1;

            pointh_2[0, 0] = 4.1;
            pointh_2[1, 0] = 0;
            pointh_2[2, 0] = 1;

            pointh_3[0, 0] = 4;
            pointh_3[1, 0] = 1;
            pointh_3[2, 0] = 1;
            //Руки 
            pointh_4[0, 0] = 3.9;
            pointh_4[1, 0] = 1;
            pointh_4[2, 0] = 1;

            pointh_5[0, 0] = 4.1;
            pointh_5[1, 0] = 1;
            pointh_5[2, 0] = 1;

            pointh_6[0, 0] = 4;
            pointh_6[1, 0] = 2;
            pointh_6[2, 0] = 1;
            //Голова
            pointh_7[0, 0] = 4.5;
            pointh_7[1, 0] = 2;
            pointh_7[2, 0] = 1;

            pointh_8[0, 0] = 4.5;
            pointh_8[1, 0] = 3;
            pointh_8[2, 0] = 1;

            pointh_9[0, 0] = 3.5;
            pointh_9[1, 0] = 3;
            pointh_9[2, 0] = 1;

            pointh_10[0, 0] = 3.5;
            pointh_10[1, 0] = 2;
            pointh_10[2, 0] = 1;
            //Глаз
            pointh_11[0, 0] = 3.5;
            pointh_11[1, 0] = 2.5;
            pointh_11[2, 0] = 1;

            pointh_12[0, 0] = 3.8;
            pointh_12[1, 0] = 2.5;
            pointh_12[2, 0] = 1;

            pointh_13[0, 0] = 3.8;
            pointh_13[1, 0] = 2.8;
            pointh_13[2, 0] = 1;

            pointh_14[0, 0] = 3.5;
            pointh_14[1, 0] = 2.8;
            pointh_14[2, 0] = 1;
            //Рот
            pointh_15[0, 0] = 3.5;
            pointh_15[1, 0] = 2.1;
            pointh_15[2, 0] = 1;

            pointh_16[0, 0] = 3.7;
            pointh_16[1, 0] = 2.1;
            pointh_16[2, 0] = 1;
            
            //Зрачок
            pointh_17[0, 0] = 3.65;
            pointh_17[1, 0] = 2.65;
            pointh_17[2, 0] = 1;
        }
        private void DrawHuman()
        {
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых
            pane.CurveList.Clear();

            // Создадим список точек
            //Ноги
            PointPairList list1 = new PointPairList();
            list1.Add(pointh_1[0, 0], pointh_1[1, 0]);
            list1.Add(pointh_3[0, 0], pointh_3[1, 0]);
            list1.Add(pointh_2[0, 0], pointh_2[1, 0]);

            //туловище
            PointPairList list2 = new PointPairList();
            list2.Add(pointh_3[0, 0], pointh_3[1, 0]);
            list2.Add(pointh_6[0, 0], pointh_6[1, 0]);

            //Руки  
            PointPairList list3 = new PointPairList();
            list3.Add(pointh_4[0, 0], pointh_4[1, 0]);
            list3.Add(pointh_6[0, 0], pointh_6[1, 0]);
            list3.Add(pointh_5[0, 0], pointh_5[1, 0]);

            //Голова
            PointPairList list4 = new PointPairList();
            list4.Add(pointh_7[0, 0], pointh_7[1, 0]);
            list4.Add(pointh_8[0, 0], pointh_8[1, 0]);
            list4.Add(pointh_9[0, 0], pointh_9[1, 0]);
            list4.Add(pointh_10[0, 0], pointh_10[1, 0]);
            list4.Add(pointh_7[0, 0], pointh_7[1, 0]);

            //Глаз
            PointPairList list5 = new PointPairList();
            list5.Add(pointh_11[0, 0], pointh_11[1, 0]);
            list5.Add(pointh_12[0, 0], pointh_12[1, 0]);
            list5.Add(pointh_13[0, 0], pointh_13[1, 0]);
            list5.Add(pointh_14[0, 0], pointh_14[1, 0]);

            //Зрачок
            PointPairList list6 = new PointPairList();
            list6.Add(pointh_17[0, 0], pointh_17[1, 0]);

            //Рот
            PointPairList list7 = new PointPairList();
            list7.Add(pointh_15[0, 0], pointh_15[1, 0]);
            list7.Add(pointh_16[0, 0], pointh_16[1, 0]);

            LineItem curve1 = pane.AddCurve("", list1, Color.Blue, SymbolType.None);
            LineItem curve2 = pane.AddCurve("", list2, Color.Blue, SymbolType.None);
            LineItem curve3 = pane.AddCurve("", list3, Color.Blue, SymbolType.None);
            LineItem curve4 = pane.AddCurve("", list4, Color.Blue, SymbolType.None);
            LineItem curve5 = pane.AddCurve("", list5, Color.Blue, SymbolType.None);
            LineItem curve6 = pane.AddCurve("", list6, Color.Red, SymbolType.Circle);
            LineItem curve7 = pane.AddCurve("", list7, Color.Blue, SymbolType.None);

            // line hidden
            curve6.Line.IsVisible = false;
            // color - blue
            curve6.Symbol.Fill.Color = Color.Red;
            // Fill type - solid fill
            curve6.Symbol.Fill.Type = FillType.Solid;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraph.Refresh();
            zedGraph.AxisChange();
            // Обновляем график
            zedGraph.Invalidate();
        }
        private void Draw_Human_Click(object sender, EventArgs e)
        {
            set_start_Human_position();
            DrawHuman();
        }
        //Применение матрицы трансформации для изменения положения человечка
        private void Transform_Pointsh()
        {
            pointh_1 = TransformMatrix * pointh_1;
            pointh_2 = TransformMatrix * pointh_2;
            pointh_3 = TransformMatrix * pointh_3;
            pointh_4 = TransformMatrix * pointh_4;
            pointh_5 = TransformMatrix * pointh_5;
            pointh_6 = TransformMatrix * pointh_6;
            pointh_7 = TransformMatrix * pointh_7;
            pointh_8 = TransformMatrix * pointh_8;
            pointh_9 = TransformMatrix * pointh_9;
            pointh_10 = TransformMatrix * pointh_10;
            pointh_11 = TransformMatrix * pointh_11;
            pointh_12 = TransformMatrix * pointh_12;
            pointh_13 = TransformMatrix * pointh_13;
            pointh_14 = TransformMatrix * pointh_14;
            pointh_15 = TransformMatrix * pointh_15;
            pointh_16 = TransformMatrix * pointh_16;
            pointh_17 = TransformMatrix * pointh_17;
        }
        private void vector_shift_H(double x, double y)
        {
            TransformMatrix[0, 2] = x;
            TransformMatrix[1, 2] = y;

            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void vector_shift_Human_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(P1_x.Text);
            y = Convert.ToDouble(P1_y.Text);
            vector_shift_H(x, y);
        }
        private void Human_scaling_Click(object sender, EventArgs e)
        {
            double k, m;
            k = Convert.ToDouble(P2_k.Text);
            m = Convert.ToDouble(P2_m.Text);

            TransformMatrix[0, 0] = k;
            TransformMatrix[1, 1] = m;

            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void reflection_H_y_eql_x()
        {
            TransformMatrix[0, 0] = 0;
            TransformMatrix[1, 1] = 0;
            TransformMatrix[0, 1] = 1;
            TransformMatrix[1, 0] = 1;

            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void reflection_Human_y_eql_x_Click(object sender, EventArgs e)
        {
            reflection_H_y_eql_x();
        }
        private void reflection_H_OY()
        {
            TransformMatrix[0, 0] = -1;

            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void reflection_Human_OY_Click(object sender, EventArgs e)
        {
            reflection_H_OY();
        }
        private void reflection_H_OX()
        {
            TransformMatrix[1, 1] = -1;

            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void reflection_Human_OX_Click(object sender, EventArgs e)
        {
            reflection_H_OX();
        }
        private void rotation_H_relatively_center()
        {
            double deg, angle;
            deg = Convert.ToDouble(P4_deg.Text);
            angle = Math.PI * deg / 180.0;

            TransformMatrix[0, 0] = Math.Cos(angle);
            TransformMatrix[0, 1] = Math.Sin(angle);
            TransformMatrix[1, 0] = -Math.Sin(angle);
            TransformMatrix[1, 1] = Math.Cos(angle);

            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void rotation_Human_relatively_center_Click(object sender, EventArgs e)
        {
            rotation_H_relatively_center();
        }
        private void rotation_H_relatively_dot(double x, double y)
        {
            double deg, angle;
            deg = Convert.ToDouble(P3_deg.Text);
            angle = Math.PI * deg / 180.0;

            //Сдвигаем фигуру в начало координат
            TransformMatrix[0, 2] = -x;
            TransformMatrix[1, 2] = -y;
            Transform_Pointsh();
            set_start_Transform_Matrix();

            //Крутим фигуру на наш угол
            TransformMatrix[0, 0] = Math.Cos(angle);
            TransformMatrix[0, 1] = Math.Sin(angle);
            TransformMatrix[1, 0] = -Math.Sin(angle);
            TransformMatrix[1, 1] = Math.Cos(angle);
            Transform_Pointsh();
            set_start_Transform_Matrix();

            //Сдвигаем фигуру в исходную точку (x,y)
            TransformMatrix[0, 2] = x;
            TransformMatrix[1, 2] = y;
            Transform_Pointsh();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void Transform_Pointsh_1leg()
        {
            pointh_1 = TransformMatrix * pointh_1;

        }
        private void Transform_Pointsh_2leg()
        {
            pointh_2 = TransformMatrix * pointh_2;
        }
        private void rotation_leg1(double deg)
        {
            double angle;
            angle = Math.PI * deg / 180.0;

            //Сдвигаем фигуру в начало координат
            TransformMatrix[0, 2] = -pointh_3[0,0];
            TransformMatrix[1, 2] = -pointh_3[1, 0];
            Transform_Pointsh_1leg();
            set_start_Transform_Matrix();

            //Крутим фигуру на наш угол
            TransformMatrix[0, 0] = Math.Cos(angle);
            TransformMatrix[0, 1] = Math.Sin(angle);
            TransformMatrix[1, 0] = -Math.Sin(angle);
            TransformMatrix[1, 1] = Math.Cos(angle);
            Transform_Pointsh_1leg();
            set_start_Transform_Matrix();

            //Сдвигаем фигуру в исходную точку (x,y)
            TransformMatrix[0, 2] = pointh_3[0, 0];
            TransformMatrix[1, 2] = pointh_3[1, 0];
            Transform_Pointsh_1leg();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void rotation_leg2(double deg)
        {
            double angle;
            angle = Math.PI * deg / 180.0;

            //Сдвигаем фигуру в начало координат
            TransformMatrix[0, 2] = -pointh_3[0, 0];
            TransformMatrix[1, 2] = -pointh_3[1, 0];
            Transform_Pointsh_2leg();
            set_start_Transform_Matrix();

            //Крутим фигуру на наш угол
            TransformMatrix[0, 0] = Math.Cos(angle);
            TransformMatrix[0, 1] = Math.Sin(angle);
            TransformMatrix[1, 0] = -Math.Sin(angle);
            TransformMatrix[1, 1] = Math.Cos(angle);
            Transform_Pointsh_2leg();
            set_start_Transform_Matrix();

            //Сдвигаем фигуру в исходную точку (x,y)
            TransformMatrix[0, 2] = pointh_3[0, 0];
            TransformMatrix[1, 2] = pointh_3[1, 0];
            Transform_Pointsh_2leg();
            DrawHuman();
            set_start_Transform_Matrix();
        }
        private void rotation_Human_relatively_dot_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(P3_x.Text);
            y = Convert.ToDouble(P3_y.Text);
            rotation_H_relatively_dot(x, y);
        }
        //Анимация ходьбы
        private void WalkAnimation_Click(object sender, EventArgs e)
        {
            double temp = 0, i = 0.01, deg = 0.5, degtemp = 0.5, k = 0;
            while(k < 6)
            {
                vector_shift_H(-i, 0);
                rotation_leg2(deg);
                rotation_leg1(-deg);
                temp += i;
                degtemp +=0.5;
                if (degtemp == 20)
                {
                    rotation_leg2(-20);
                    rotation_leg1(20);
                    degtemp = 0;
                    k++;
                }
            }
        }

        //Начальная единичная матрица
        private void set_start_Transform_Matrix() 
        {
            TransformMatrix[0, 0] = 1;
            TransformMatrix[0, 1] = 0;
            TransformMatrix[0, 2] = 0;
            TransformMatrix[1, 0] = 0;
            TransformMatrix[1, 1] = 1;
            TransformMatrix[1, 2] = 0;
            TransformMatrix[2, 0] = 0;
            TransformMatrix[2, 1] = 0;
            TransformMatrix[2, 2] = 1;
        }
        //Применение матрицы трансформации для изменения положения фигуры
        private void Transform_Points()
        {
            point_1 = TransformMatrix * point_1;
            point_2 = TransformMatrix * point_2;
            point_3 = TransformMatrix * point_3;
            point_4 = TransformMatrix * point_4;
            point_5 = TransformMatrix * point_5;
            point_6 = TransformMatrix * point_6;
            point_7 = TransformMatrix * point_7;
        }
        //Сдвиг фигуры на вектор
        private void vector_shift_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(P1_x.Text);
            y = Convert.ToDouble(P1_y.Text);

            TransformMatrix[0, 2] = x;
            TransformMatrix[1, 2] = y;

            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }
        //Перенести фигуру в начальное положение
        private void start_fugure_position_Click(object sender, EventArgs e)
        {
            set_start_position();
            DrawFigure();
        }

        //Отражение относительно прямой y = x
        private void reflection_y_eql_x_Click(object sender, EventArgs e)
        {
            TransformMatrix[0, 0] = 0;
            TransformMatrix[1, 1] = 0;
            TransformMatrix[0, 1] = 1;
            TransformMatrix[1, 0] = 1;
            
            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }
        //Отражение относительно оси OY
        private void reflection_OY_Click(object sender, EventArgs e)
        {
            TransformMatrix[0, 0] = -1;

            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }
        //Отражение относительно оси OX
        private void reflection_OX_Click(object sender, EventArgs e)
        {
            TransformMatrix[1, 1] = -1;

            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }
        //Масштабирование фигуры
        private void figure_scaling_Click(object sender, EventArgs e)
        {
            double k, m;
            k = Convert.ToDouble(P2_k.Text);
            m = Convert.ToDouble(P2_m.Text);

            TransformMatrix[0, 0] = k;
            TransformMatrix[1, 1] = m;

            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }
        //Поворот относительно центра
        private void rotation_relatively_center_Click(object sender, EventArgs e)
        {
            double deg, angle;
            deg = Convert.ToDouble(P4_deg.Text);
            angle = Math.PI * deg  / 180.0;

            TransformMatrix[0, 0] = Math.Cos(angle);
            TransformMatrix[0, 1] = Math.Sin(angle);
            TransformMatrix[1, 0] = -Math.Sin(angle);
            TransformMatrix[1, 1] = Math.Cos(angle);

            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }
        //Поворот относительно точки
        private void rotation_relatively_dot_Click(object sender, EventArgs e)
        {
            double deg, angle, x, y;
            deg = Convert.ToDouble(P3_deg.Text);
            angle = Math.PI * deg / 180.0;
    
            x = Convert.ToDouble(P3_x.Text);
            y = Convert.ToDouble(P3_y.Text);

            //Сдвигаем фигуру в начало координат
            TransformMatrix[0, 2] = -x;
            TransformMatrix[1, 2] = -y;
            Transform_Points();
            set_start_Transform_Matrix();

            //Крутим фигуру на наш угол
            TransformMatrix[0, 0] = Math.Cos(angle);
            TransformMatrix[0, 1] = Math.Sin(angle);
            TransformMatrix[1, 0] = -Math.Sin(angle);
            TransformMatrix[1, 1] = Math.Cos(angle);
            Transform_Points();
            set_start_Transform_Matrix();
            
            //Сдвигаем фигуру в исходную точку (x,y)
            TransformMatrix[0, 2] = x;
            TransformMatrix[1, 2] = y;
            Transform_Points();
            DrawFigure();
            set_start_Transform_Matrix();
        }

    }
}
