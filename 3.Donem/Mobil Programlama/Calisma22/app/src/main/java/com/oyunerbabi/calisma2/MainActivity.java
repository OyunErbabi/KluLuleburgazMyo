package com.oyunerbabi.calisma2;

import android.os.Bundle;
import android.widget.GridView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    GridView grid;
    ArrayList<Integer> images = new ArrayList<>();
    ArrayList<String> texts = new ArrayList<>();
    GridAdapter adapter;

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

        grid = findViewById(R.id.grid);
        images.add(R.drawable.gs);
        images.add(R.drawable.fb);
        images.add(R.drawable.bjk);
        images.add(R.drawable.genc);

        texts.add("Galatasaray");
        texts.add("Fenerbahçe");
        texts.add("BJK");
        texts.add("Gençler Birliği");

        adapter = new GridAdapter(images,texts,this);
        grid.setAdapter(adapter);

        grid.setOnItemClickListener((parent, view, position, id) -> {
            Toast.makeText(this, "Tıklandı: "+texts.get(position), Toast.LENGTH_SHORT).show();
        });


    }
}