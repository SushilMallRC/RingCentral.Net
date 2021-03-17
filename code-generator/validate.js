import yaml from 'js-yaml'
import fs from 'fs'

const doc = yaml.load(fs.readFileSync('rc-platform.yml', 'utf8'))

const paths = Object.keys(doc.paths)

const cache = { get: [], put: [], post: [], delete: [], patch: [] }

let markdown = '# Swagger spec validation issues'

for (const path of paths) {
  const operations = Object.keys(doc.paths[path])
  for (const operation of operations) {
    cache[operation].push(path)
  }
}

markdown += `

## HTTP GET but no response body
`
const getOkPaths = [
  '/restapi/v1.0/status',
  '/restapi/oauth/authorize',
  '/scim/v2/health'
]
for (const path of cache.get) {
  if (getOkPaths.includes(path)) {
    continue
  }
  const responses = doc.paths[path].get.responses
  const response = responses['200'] || responses.default
  if (!response.content) {
    markdown += `\n- ${path}`
  }
}

markdown += `

## HTTP POST but no request body
`
const postOkPaths = [
  '/restapi/v1.0/glip/groups/{groupId}/webhooks',
  '/restapi/v1.0/account/{accountId}/telephony/sessions/{sessionId}/parties/{partyId}/recordings', // other branches
  '/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings', // docs branch
  '/restapi/oauth/token',
  '/restapi/oauth/revoke'
]
for (const path of cache.post) {
  if (postOkPaths.includes(path) ||
    path.endsWith('/end') ||
    path.endsWith('/join') ||
    path.endsWith('/leave') ||
    path.endsWith('/archive') ||
    path.endsWith('/unarchive') ||
    path.endsWith('/favorite') ||
    path.endsWith('/unfavorite') ||
    path.endsWith('/read') ||
    path.endsWith('/unread') ||
    path.endsWith('/activate') ||
    path.endsWith('/suspend') ||
    path.endsWith('/renew') ||
    path.endsWith('/hold') ||
    path.endsWith('/unhold') ||
    path.endsWith('/reject') ||
    path.endsWith('/lock') ||
    path.endsWith('/unlock') ||
    path.endsWith('/park') ||
    path.endsWith('/publish')
  ) {
    continue
  }
  if (!doc.paths[path].post.requestBody) {
    markdown += `\n- ${path}`
  }
}

markdown += `

## HTTP PUT but no request body
`
for (const path of cache.put) {
  if (!doc.paths[path].put.requestBody) {
    markdown += `\n- ${path}`
  }
}

markdown += `

## HTTP PATCH but no request body
`
for (const path of cache.patch) {
  if (!doc.paths[path].patch.requestBody) {
    markdown += `\n- ${path}`
  }
}

markdown += `

## string type as definitions
`
for (const schema of Object.keys(doc.components.schemas)) {
  if (doc.components.schemas[schema].type === 'string') {
    markdown += `\n- ${schema}`
  }
}

markdown += `

## array type as definitions
`
for (const schema of Object.keys(doc.components.schemas)) {
  if (doc.components.schemas[schema].type === 'array') {
    markdown += `\n- ${schema}`
  }
}

markdown += `

## Anonymouse types
`
for (const dKey of Object.keys(doc.components.schemas)) {
  const properties = doc.components.schemas[dKey].properties
  if (!properties) {
    continue
  }
  for (const pKey of Object.keys(properties)) {
    const property = properties[pKey]
    if (property.properties || (property.items && property.items.properties)) {
      markdown += `\n- Definition: \`${dKey}\`; Property name: \`${pKey}\``
    }
  }
}

fs.writeFileSync('validate.md', markdown)

console.log(markdown)
