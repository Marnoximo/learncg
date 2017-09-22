#version 330 core

struct Material {
	vec3 ambient;
	vec3 specular;
	vec3 diffuse;
	float shininess;
};

struct Light {
	vec3 position; // Using LightPos (in view space) instead of this light position value (world space)
	vec3 ambient;
	vec3 diffuse;
	vec3 specular;

};

out vec4 FragColor;
in vec3 Normal;
in vec3 fragPos;
uniform Material material;
uniform Light light;
uniform vec3 viewPos;
uniform vec3 objectColor;
uniform vec3 lightColor;
in vec3 LightPos;

void main()
{
	// ambient
	vec3 ambient = light.ambient * material.ambient;

	// diffuse
	vec3 norm = normalize(Normal);
	vec3 lightDir = normalize(LightPos - fragPos);
	float diff = max(dot(norm, lightDir), 0.0f);
	vec3 diffuse = (diff * material.diffuse) * light.diffuse;

	// specular
	vec3 viewDir = normalize(-fragPos); // the viewer is always at (0,0,0) in view-space, so viewDir is (0,0,0) - Position => -Position
	vec3 reflectDir = reflect(-lightDir, norm);
	float spec = pow(max(dot(viewDir, reflectDir), 0.0f), 64);
	vec3 specular = (spec * material.specular) * light.specular;

	// result
	vec3 result = ambient + diffuse + specular;
    FragColor = vec4(result, 1.0);
}