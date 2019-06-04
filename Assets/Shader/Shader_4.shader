Shader "Custom/Shader_4" {
 Properties
   {
       _MainTex ("MainTex", 2D) = "white"{}
   }

   CGINCLUDE
   #include "UnityCG.cginc"
   #define PI 3.14159265359
   float3x3 scale(float2 scale)
   {
    return float3x3(scale.x, 0, 0,
                    0, scale.y, 0,
                    0, 0, 1);
	}

   float box(float2 st)
   {
   		fixed2 size = fixed2(0.5,0.5);
    	fixed2 leftbottom = fixed2(0.5,0.5) - size * 0.5;
    	fixed2 uv = step(leftbottom, st);
    	uv *= step(leftbottom, 1-st);
    	return uv.x*uv.y;
    } 
    float2x2 rotate(float angle)
    {
        return float2x2(cos(angle), -sin(angle),
                        sin(angle), cos(angle));
    }
    float4 frag(v2f_img i) : SV_Target
	{
        float2 st = i.uv*10;
        st = frac(st);
        fixed4 red   = fixed4(0,0,0,1);
        fixed4 blue   = fixed4(0,0,1,1);
        float t = _Time.y*5;
        st -= 0.5;
        st = mul(rotate(sin(t) * PI), st);
        st = mul(scale(sin(t) + 1), float3(st, 1));
      	st +=0.5;
       	return lerp(red,blue,box(st));
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
