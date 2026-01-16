package com.oyunerbabi.calisma;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.GridView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.recyclerview.widget.GridLayoutManager;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<Integer> resim = new ArrayList<Integer>();
    ArrayList<String> metin = new ArrayList<String>();
    GridView grid;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        grid = findViewById(R.id.gridViewArea);
        resim.add(R.drawable.gs);
        resim.add(R.drawable.fb);
        resim.add(R.drawable.bjk);
        resim.add(R.drawable.genc);

        metin.add("Galatasaray");
        metin.add("Fenerbahçe");
        metin.add("Beşiktaş");
        metin.add("Gençler Birliği");

        gridadapter gridadapter = new gridadapter(resim,metin,this);
        grid.setAdapter(gridadapter);

        grid.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Toast.makeText(MainActivity.this,metin.get(position)+" Tıklandı",Toast.LENGTH_SHORT).show();
            }
        });

    }
}