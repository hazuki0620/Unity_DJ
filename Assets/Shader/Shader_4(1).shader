Shader "Custom/Shader_4(1)" 
{
    Properties
    {
        _MainTex ("MainTex", 2D) = "white"{}
    }

    CGINCLUDE
    #include "UnityCG.cginc"
    float _Size0;
    float _Size1;
    float _Size2;
    float _Size3;
    float2 random2(float2 st)
    {
        st = float2(dot(st, float2(127.1, 311.7)),
                    dot(st, float2(269.5, 183.3)));
        return -1.0 + 2.0 * frac(sin(st) * 43758.5453123);
    }
    
    float4 frag(v2f_img i) : SV_Target
    {
   
        float2 st = i.uv;
        st *= 1.0;

        float2 ist = floor(st);
        float2 fst = frac(st);

        float min_distance = 10;
        float2 min_point = 0;

        for (int y = -1; y <= 0; y++)
        for (int x = -1; x <= 0; x++)
        {
        	int i=0;
        	float2 p;
            float2 neighbor = float2(x, y);
            if(i==0){
         		//p = 0.5 + 0.5 * sin(_Size0 + 6.2831 * random2(ist + neighbor));
         		p=0.5*sin(_Size0+random2(ist + neighbor))+0.5*sin(_Size0+random2(ist + neighbor));
            }
            if(i==1){
           		//p = 0.5 + 0.5 * sin(_Size1 + 6.2831 * random2(ist + neighbor));
           		p=0.5*sin(_Size1+random2(ist + neighbor))+0.5*sin(_Size1+random2(ist + neighbor));
            }
            if(i==2){
           		//p = 0.5 + 0.5 * sin(_Size2 + 6.2831 * random2(ist + neighbor));
           		p=0.5*sin(_Size2+random2(ist + neighbor))+0.5*sin(_Size2+random2(ist + neighbor));
            }
            if(i==3){
            	//p = 0.5 + 0.5 * sin(_Size3 + 6.2831 * random2(ist + neighbor));
            	p=0.5*sin(_Size3+random2(ist + neighbor))+0.5*sin(_Size3+random2(ist + neighbor));
            }

            float distance = length(neighbor + p - fst);
            if (distance < min_distance)
            {
                min_distance = distance;
                min_point = p;
            }
            i++;
        }
        
        return float4(min_point, 1, 1);
    }
    
    ENDCG

    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            ENDCG
        }
    }
}