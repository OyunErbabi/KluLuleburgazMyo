package com.oyunerbabi.hafta3_2;

import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    TextView yazi;
    CheckBox erkek,kadin;

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

        yazi = findViewById(R.id.yazi);
        erkek = findViewById(R.id.Erkek);
        kadin = findViewById(R.id.Kadin);

        /*
        erkek.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                yazi.setText("Erkek Secildi");
            }
        });
        */

        erkek.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(@NonNull CompoundButton buttonView, boolean isChecked) {
                if (isChecked)
                {
                    yazi.setText("Erkek Seçildi");
                    kadin.setChecked(false);
                }
            }
        });


        kadin.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(@NonNull CompoundButton buttonView, boolean isChecked) {
                if (isChecked)
                {
                    yazi.setText("Kadın Seçildi");
                    erkek.setChecked(false);
                }
            }
        });

    }
}